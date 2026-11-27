# Lab: Brief, Schedule, Approve

You work in pairs. Each of you briefs your own Autopilot and plays the supplier for your partner.

Duration: about 40 minutes.

## What You Build

- A written brief for your Autopilot as the canteen's Supplier Review Lead
- A routine that runs every weekday at 08:00
- A routine that starts when your partner mails about a delivery
- One approval you answer yourself

## Prerequisites

- Your Autopilot is ready ([Create Your Autopilot](../01-meet-autopilot/lab-01-create-your-autopilot.md)).
- `supplier-tracker.xlsx` from [Place the Teammate on the Map](../../../demos/07-autopilot/01-meet-autopilot/demo-place-teammate-on-map.md) in your OneDrive.
- Your partner's email address.

## Steps

1. **Write the brief.** Copy this into your Autopilot's main conversation and replace the two placeholders:

   ```text
   You are my Supplier Review Lead for the canteen.
   Outcome: every delivery for this week's menu arrives on time, and I hear about risks before Thursday noon.
   Sources: supplier-tracker.xlsx in my OneDrive and mail from <partner's email>.
   Boundaries: draft replies to suppliers, but ask me before you send anything. Never change the menu.
   Delivery: a short summary in our Teams chat.
   ```

2. **Add a scheduled routine.** Send:

   ```text
   Every weekday at 08:00, check the tracker and send me the summary in Teams: late deliveries first, then this week's risks.
   ```

   Open the management panel and confirm the routine shows with its schedule.

3. **Add an event routine.** Send:

   ```text
   When <partner's email> mails about a delivery, update the tracker row for that supplier and tell me in Teams what changed.
   ```

4. **Play the supplier.** Mail your partner a delivery change, for example:

   ```text
   Subject: Rolls delivery
   The 600 rolls arrive Saturday instead of Friday. Danube Bakery
   ```

5. **Watch your Autopilot.** When your partner's mail arrives, open **Activity**. Find the item, then open `supplier-tracker.xlsx` and check the row it changed.

6. **Trigger an approval.** Send:

   ```text
   Reply to the supplier and ask whether a partial delivery on Friday morning is possible.
   ```

   Your Autopilot drafts the reply and shows an approval card in your Teams chat, because your brief said so. Read the draft and the recipients, then select **Allow** or **Deny**. Note what it does in each case.

7. **Change a routine.** In the management panel, open **Routines**, turn the 08:00 routine's switch off, then on again.

## Check Your Work

- [ ] The brief has an outcome, sources, boundaries and a delivery place.
- [ ] Two routines are listed: one on a schedule, one on mail from your partner.
- [ ] The tracker row changed after your partner's mail.
- [ ] You answered one approval.

## Think About It

- Which actions ran without asking you, and which waited? How does that match your boundaries?
- What would you add to the brief before you trusted it with a real supplier?
