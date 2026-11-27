# Demo: Follow-Through on the Supplier Review

Autopilot owns the canteen supplier review, reacts to a supplier mail, and turns a Teams request into a meeting and a decision document, asking before it involves anyone new.

Duration: about 25 minutes.

## Before the Demo

1. Your presenter account has an Autopilot with the routine from [Place the Teammate on the Map](../01-meet-autopilot/demo-place-teammate-on-map.md), and `supplier-tracker.xlsx` is in your OneDrive.
2. A second account plays the supplier and a colleague. Sign it in to Outlook and Teams in a private browser window.
3. A Teams channel **Canteen Ops** with you, the second account and your Autopilot as members. Add your Autopilot the way you add a person.

## Steps

1. **Hand over the outcome.** In your Autopilot's main conversation:

   ```text
   You own the canteen supplier review this week. Keep supplier-tracker.xlsx current. When a supplier mails about a delivery, update the tracker and tell me if Friday's menu is at risk. Draft supplier replies, but ask me before you send anything.
   ```

2. **Let a signal arrive.** From the second account, mail yourself:

   ```text
   Subject: Oat milk delivery
   Our oat milk delivery moves from Wednesday to Friday 14:00. Sorry for the delay. Alpine Dairy
   ```

3. **Watch it react.** Open the management panel and then **Activity**. Show the new item: Autopilot read the mail, updated the tracker and flagged the risk to Friday's menu. Open `supplier-tracker.xlsx` and show the changed row: the result lives in the file, not in a chat message.

4. **Ask in the team channel.** In **Canteen Ops**, write as yourself:

   ```text
   @<your Autopilot> can you pull this into a decision document and set up a 30-minute call with the group this afternoon?
   ```

   Autopilot answers with a free slot and asks whether it should book it. Reply `Book it`.

5. **Show the approval.** Autopilot sends the invite and posts a link to the decision document. If it wants to add someone outside the channel, it asks first in your Teams chat. Answer `Continue`.

6. **Open the results.** Open the decision document in Word and the meeting in Outlook. Then return to **Activity** and show the full trail of what Autopilot did.

## Talking Points

- The brief named the outcome, the sources and a boundary ("ask me before you send anything").
- Crosscheck, the automated review, compares each action with what you asked. Matching actions run; the rest show an approval card with **Allow** and **Deny**. Autopilot can't approve itself, and payments always ask.
- Check results where they land (the tracker, the document, the invite), not in a progress message.

## If It Doesn't Go to Plan

| What happens | Do this |
| --- | --- |
| No reaction to the mail after a few minutes | Paste the mail into the main conversation and ask Autopilot to handle it. |
| The @-mention isn't answered | Check that your Autopilot is a member of the channel. If the tenant doesn't show channel mentions yet, make the same request in your private conversation with Autopilot. |
