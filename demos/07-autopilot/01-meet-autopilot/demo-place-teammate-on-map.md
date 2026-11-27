# Demo: Place the Teammate on the Map

The presenter runs one canteen request through Chat, Cowork and Autopilot so the class sees where each mode stops.

Duration: about 25 minutes.

## What You Show

| Mode | Request | Where it stops |
| --- | --- | --- |
| Chat | Which suppliers are late this week? | After the answer |
| Cowork | Draft follow-ups and a one-page summary | When the drafts are delivered |
| Autopilot | Keep the weekly supplier review on track | Never on its own: it keeps going until you stop it |

## Before the Demo

1. Your presenter account has an Autopilot that finished provisioning (see [Create Your Autopilot](../../../labs/07-autopilot/01-meet-autopilot/lab-01-create-your-autopilot.md)).
2. Create `supplier-tracker.xlsx` in your OneDrive with this table:

   | Supplier | Item | Due | Status |
   | --- | --- | --- | --- |
   | Alpine Dairy | Oat milk, 60 l | Wednesday | Late |
   | Valley Greens | Salad mix, 40 kg | Thursday | On time |
   | Danube Bakery | Rolls, 600 pcs | Friday | Late |
   | Roastery North | Coffee beans, 12 kg | Friday | On time |

3. Open [copilot.cloud.microsoft](https://copilot.cloud.microsoft) in a browser window on the projector.

## Steps

1. **Chat.** Start a new chat and attach `supplier-tracker.xlsx`:

   ```text
   Which canteen suppliers are late this week?
   ```

   Copilot answers with Alpine Dairy and Danube Bakery. Point out that the work ends with the answer.

2. **Cowork.** Switch to Cowork and attach the same file:

   ```text
   Draft a follow-up mail to each late supplier and a one-page summary for the canteen lead.
   ```

   Cowork plans the steps, writes two drafts and a Word summary, and pauses before anything is sent. Point out that it stops when the deliverable is done.

3. **Autopilot.** Open your Autopilot by its name on the **Home** tab:

   ```text
   Keep the weekly canteen supplier review on track. Every weekday at 08:00, check supplier-tracker.xlsx, draft a follow-up for every late delivery, and tell me in Teams when a delivery puts Friday's menu at risk. Don't send anything to suppliers without asking me.
   ```

   Autopilot confirms the plan and sets up a routine. Open the management panel in the upper-right corner and show the new routine and the **Activity** list.

4. **Close.** Show the table from [What You Show](#what-you-show) again. Chat and Cowork waited for the next prompt; Autopilot will run again tomorrow at 08:00 without one.

## Talking Points

- Autopilot plans and acts without asking at each step. Before it sends, shares, deletes or changes something, an automated review compares the action with the request.
- The boundary in the request ("don't send anything without asking me") is part of the brief, and topic 02 builds on it.
- Learners create their own Autopilot in the lab right after this demo, because provisioning takes 10 to 30 minutes.
