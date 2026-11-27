using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using Microsoft.Identity.Client;
using Microsoft.Identity.Client.Broker;

const string endpoint = "https://workiq.svc.cloud.microsoft/a2a/";
const string scope = "api://workiq.svc.cloud.microsoft/WorkIQAgent.Ask";

string? appId = null, tenant = null;
var question = "What meetings do I have today?";
for (var i = 0; i < args.Length; i++)
{
    switch (args[i])
    {
        case "--appid": appId = args[++i]; break;
        case "--tenant": tenant = args[++i]; break;
        default: question = args[i]; break;
    }
}

var builder = PublicClientApplicationBuilder.Create(appId)
    .WithAuthority($"https://login.microsoftonline.com/{tenant}")
    .WithDefaultRedirectUri();

if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
{
    builder.WithParentActivityOrWindow(ConsoleWindowHandle)
        .WithBroker(new BrokerOptions(BrokerOptions.OperatingSystems.Windows));
}

var app = builder.Build();
var scopes = new[] { scope };

AuthenticationResult auth;
try
{
    auth = await app.AcquireTokenSilent(scopes, PublicClientApplication.OperatingSystemAccount).ExecuteAsync();
}
catch (MsalUiRequiredException)
{
    auth = await app.AcquireTokenInteractive(scopes).ExecuteAsync();
}

using var http = new HttpClient();
http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", auth.AccessToken);
http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
http.DefaultRequestHeaders.TryAddWithoutValidation("A2A-Version", "1.0");

var request = new
{
    jsonrpc = "2.0",
    id = Guid.NewGuid().ToString(),
    method = "SendMessage",
    @params = new
    {
        message = new
        {
            role = "ROLE_USER",
            messageId = Guid.NewGuid().ToString(),
            parts = new[] { new { text = question } },
            metadata = new
            {
                Location = new
                {
                    timeZoneOffset = (int)TimeZoneInfo.Local.BaseUtcOffset.TotalMinutes,
                    timeZone = TimeZoneInfo.Local.Id
                }
            }
        }
    }
};

var response = await http.PostAsync(endpoint, new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json"));
var body = await response.Content.ReadAsStringAsync();
Console.WriteLine($"[{(int)response.StatusCode} {response.ReasonPhrase}]");

using var doc = JsonDocument.Parse(body);
if (doc.RootElement.TryGetProperty("error", out var error))
{
    Console.WriteLine(error);
    return;
}

var task = doc.RootElement.GetProperty("result").GetProperty("task");
var answer = new StringBuilder();
foreach (var artifact in task.GetProperty("artifacts").EnumerateArray())
{
    foreach (var part in artifact.GetProperty("parts").EnumerateArray())
    {
        answer.Append(part.GetProperty("text").GetString());
    }
}

Console.WriteLine(answer);
Console.WriteLine();
Console.WriteLine("Citations:");
foreach (var attribution in FindAttributions(task))
{
    var type = attribution.TryGetProperty("attributionType", out var t) ? t.ToString() : "";
    var name = attribution.TryGetProperty("providerDisplayName", out var p) ? p.GetString() : "";
    var url = attribution.TryGetProperty("seeMoreWebUrl", out var u) ? u.GetString() : "";
    Console.WriteLine($"- [{type}] {name} {url}");
}

static IEnumerable<JsonElement> FindAttributions(JsonElement element)
{
    if (element.ValueKind == JsonValueKind.Object)
    {
        foreach (var property in element.EnumerateObject())
        {
            if (property.Name == "attributions" && property.Value.ValueKind == JsonValueKind.Array)
            {
                foreach (var item in property.Value.EnumerateArray()) yield return item;
            }
            else
            {
                foreach (var found in FindAttributions(property.Value)) yield return found;
            }
        }
    }
    else if (element.ValueKind == JsonValueKind.Array)
    {
        foreach (var item in element.EnumerateArray())
        {
            foreach (var found in FindAttributions(item)) yield return found;
        }
    }
}

[DllImport("kernel32.dll")] static extern IntPtr GetConsoleWindow();
[DllImport("user32.dll", ExactSpelling = true)] static extern IntPtr GetAncestor(IntPtr hwnd, uint flags);
static IntPtr ConsoleWindowHandle() { var c = GetConsoleWindow(); var r = GetAncestor(c, 3); return r != IntPtr.Zero ? r : c; }
