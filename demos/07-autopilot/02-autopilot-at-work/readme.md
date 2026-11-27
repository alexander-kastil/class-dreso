# Autopilot at Work

Autopilot plans and carries out work without asking at each step. This topic covers how to brief it, how routines keep it busy, where you review its work, and how approvals keep consequential actions in your hands.

## Brief It Like a Colleague

A good brief reads like a handover to a new colleague. It names four things:

| Part | Question it answers |
| --- | --- |
| Outcome | What should be true when the work is done? |
| Sources and people | Which files, mail and people should it work with? |
| Boundaries | What may it never do, and what must it ask about first? |
| Delivery | Where should results land: a Teams chat, a document, a mail? |

Example brief for the canteen:

```text
You are my Supplier Review Lead for the canteen.
Outcome: every delivery for this week's menu arrives on time, and I hear about risks before Thursday noon.
Sources: supplier-tracker.xlsx in my OneDrive and mail from our suppliers.
Boundaries: draft replies to suppliers, but ask me before you send anything. Never change the menu.
Delivery: a short summary in our Teams chat.
```

## Routines

A routine is work that repeats. It runs on a schedule (every weekday at 08:00) or when an event happens (a supplier mail arrives). Give each routine complete instructions, its sources, recipients and a place to deliver the result: a scheduled run doesn't inherit everything said in the conversation that created it. Your routines are private to you.

Describe what you want in plain language and Autopilot decides the shape: work it can finish now becomes a task in the conversation, timed or event-based work becomes a routine, and work that belongs to a routine you already have is added to it. Starter routines are suggested when you create your Autopilot. In the management panel, **Routines** shows each routine with its schedule and a switch that turns scheduled runs on or off, and its menu offers **Run now**, **Edit** and **Delete**.

Background work depends on access and available services. A pending approval, a missing permission or a service issue can hold a scheduled run, so there is no guarantee that a routine finishes at an exact time.

## Activity

**Activity**, in the management panel in the upper-right corner, shows **Working now** and **Needs your input** first, then completed work and routine runs. Filter it by type (chats, routines, files, approvals), source (Teams, Outlook) or status (needs you, in progress, didn't finish, completed). Check the actual result where it landed (the tracker, the document, the invite): a progress message or an approval proves nothing about the result.

## Approvals and Automated Review

Before Autopilot sends, shares, deletes or changes something, a second AI model reviews the action against what you asked for. Microsoft called this review Crosscheck at Ignite; Microsoft Learn calls it the automated review system.

- Reading, searching and drafting run without interruption; a small share is spot-checked.
- Sending, sharing, deleting or changing content, and creating or changing a routine, run when they match your request. Otherwise you get an approval card in your Teams chat with Autopilot, and in Copilot if you asked there.
- Payments and other sensitive browser steps always ask, even when you asked for them.
- **Allow** runs the card's actions once and **Deny** cancels them. There is no option to always allow an action.
- Only your own messages count as requests. Instructions inside a mail, a document or a web page authorize nothing.

There are no user or admin settings for the automated review in this release, and automated checks can make mistakes, so the boundaries in your brief ("ask me before you send anything") stay part of the protection. Read Approval Cards reads the approval card in detail.

## Plugins and Skills

Skills hold task instructions, for example how to turn meeting notes into a tracker. Plugins connect Autopilot to tools and services and can bring skills of their own. On **Plugins** you add plugins from the catalog, create or upload a skill and share it with coworkers, and you call a skill by typing `/` in the composer.

A plugin or skill doesn't grant access. The account that acts still needs permission for the mail, calendar, files and tools a task uses. Extend Autopilot with Skills, Plugins & Edge builds and shares a skill.

## Browser and Computer

Autopilot works on a Microsoft-managed cloud computer, separate from your device, and can't reach the folders and apps on your device. Where your admin enables it, Autopilot can also work in your own Microsoft Edge, for example to fill in a web form for you to review. Edge must be open, signed in with your work account and connected to Autopilot, and only requests you make in your private conversation use it: routines don't.

## Working with Others

At your request, Autopilot messages coworkers in Teams, follows up on commitments and helps schedule meetings, with approval. Everyone in a Teams chat sees the messages Autopilot sends there, so check the recipients before you allow a message. You can also add your Autopilot as the **Assistant** in your Microsoft 365 profile; that shows the relationship and grants no permissions. Ignite also showed coworkers @-mentioning an Autopilot in channels: check what your tenant shows before you teach it.

## What Is Still Coming

At Microsoft Ignite 2026, Microsoft named these as coming soon: goals as a named feature, voice through the phone's Action button, and computer use on a local Windows PC. Autopilots shared by several people were not rolling out yet. Teach only what the tenant shows on the day.

## Hands-On Demo

[Follow-Through on the Supplier Review](demo-follow-through.md): Autopilot reacts to a supplier mail, then turns a Teams request into a meeting and a decision document, asking before it involves anyone new. 25 minutes.

## Hands-On Lab

[Brief, Schedule, Approve](../../../labs/07-autopilot/02-autopilot-at-work/lab-01-brief-schedule-approve.md): write the brief, add a scheduled and an event routine, and answer an approval. 40 minutes, in pairs.

## Links & Resources

- [Autopilot (Frontier) overview](https://learn.microsoft.com/copilot/autopilot/overview)
- [Use Autopilot (Frontier)](https://learn.microsoft.com/copilot/autopilot/using)
- [How Autopilot reviews actions](https://learn.microsoft.com/copilot/autopilot/approval)
- [Customize what Autopilot can do](https://learn.microsoft.com/copilot/autopilot/plugins)
- [Work in your Microsoft Edge browser](https://learn.microsoft.com/copilot/autopilot/edge)
- [Application card: Autopilot (Frontier)](https://learn.microsoft.com/copilot/autopilot/microsoft-autopilot-application-card)
- [Ignite BRK202: Automate the Follow-Through with Autopilot](https://ignite.microsoft.com/en-US/sessions/1787856603644001EiOR-1791588098392001CZY7), demo from 00:06:14, Crosscheck at 00:18:29
- [Ignite BRK201: Home, your starting point for work in the Copilot app](https://ignite.microsoft.com/en-US/sessions/1787856603496001EOOR-1791588069487001CY09), plugins at 00:07:10
- [Microsoft Mechanics: Introducing Autopilot](https://www.youtube.com/watch?v=KtV_f3chj9A)
