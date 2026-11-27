# Check the Hosted Apps for the REST API and MCP Labs

Two labs give an agent tools that call apps hosted for the class in Azure, so participants run nothing on their own machines. Both apps accept calls without a token, so the labs need no Entra ID app registration and no consent. The participants' browsers and the Power Platform environment must reach both addresses over HTTPS.

## Apps

| App | Address | Lab | What the agent uses |
| --- | --- | --- | --- |
| HR Service API (REST) | `https://lab-hr-service.azurewebsites.net` | [Call a Hosted REST API from an Agent](../labs/03-cs-tools/05-rest-api/lab-01-call-a-secured-rest-api.md) | A Power Platform custom connector imported from [hr-service-swagger.json](../labs/03-cs-tools/05-rest-api/hr-service-swagger.json), with four operations on a candidate list: `getCandidates`, `getCandidate`, `addCandidate` and `removeCandidate` |
| HR MCP Server | `https://lab-human-resource-mcp.azurewebsites.net` | [Give an Agent MCP Tools on the Hosted Server](../labs/03-cs-tools/06-mcp/lab-01-give-an-agent-mcp-tools.md) | An MCP tool in Copilot Studio that discovers six tools at runtime: `list_employees`, `search_employees`, `add_employee`, `update_employee`, `remove_employee` and `assign_shift` |

## What IT checks

- **Custom connectors**: the data policy of the lab environment allows custom connectors, so the REST API lab can create the `HR-Services` connector with **No authentication**.
- **MCP tools**: the data policy allows the connector the MCP tool registers, so the agent can call the HR MCP Server.
- **Shared data**: both apps hold one data set for the whole class. The HR Service API keeps its candidates in memory and returns to the seed data on restart; the HR MCP Server writes to a shared database. Participants use their own names when they add records.

## Source

The code of both apps ships with the class: the HR Service API in [hr-service](../labs/03-cs-tools/05-rest-api/hr-service) beside the REST API lab, and the HR MCP Server in [src/hr-mcp-server](../src/hr-mcp-server).
