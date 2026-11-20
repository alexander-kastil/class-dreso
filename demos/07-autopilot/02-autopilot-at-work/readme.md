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

A routine is work that repeats. It runs on a schedule (every weekday at 08:00) or when an event happens (a supplier mail arrives). Give each routine complete instructions and a place to deliver the result. Starter routines are suggested when you create your Autopilot, and you can add, edit, pause or remove routines in the management panel.

Background work depends on access and available services. A pending approval, a missing permission or a service issue can hold a scheduled run, so there is no guarantee that a routine finishes at an exact time.

## Activity

**Activity**, in the management panel in the upper-right corner, lists running work, requests for your input and routine results. Check the actual result where it landed (the tracker, the document, the invite) instead of treating a progress message as proof that the work is done.

## Approvals and Crosscheck

Before Autopilot sends, shares, deletes or changes something, an automated review called Crosscheck compares the action with what you asked for:

- Actions that match your request run. The others wait in **Activity** and in Teams for your approval.
- The review uses a second model in a trusted service, so Autopilot can't approve its own actions.
- Payments and other high-impact actions always ask.
- Automated checks can make mistakes. Your boundaries in the brief ("ask me before you send anything") are part of the protection.

When your admin activated Autopilot, they acknowledged that it may act without asking at each step. That acknowledgement is part of how Autopilot works and can't be turned off.

## Plugins and Skills

Plugins connect Autopilot to agents, skills and services, from Microsoft and from other vendors. IT approves a plugin once, and it then works in Chat, Cowork, Code and Autopilot. Skills hold step-by-step know-how, for example how to build a weekly briefing.

A plugin or skill doesn't grant access. The account that acts still needs permission for the mail, calendar, files and tools a task uses.

## Browser and Computer

Autopilot has its own cloud computer, separate from your device, and can use a browser there: for example to fill in a web form such as an expense report, stopping when an entry needs your input. Where your admin allows it, Autopilot can also work in your own Microsoft Edge, which must be open, signed in with your work account and connected to Autopilot. It can't reach the folders and apps on your device.

## Working with Others

Coworkers can @-mention your Autopilot in Teams chats and channels and mail it. It answers questions, books meetings and writes documents for the group. You can limit who may talk to it and stop it in a channel. Requests from others need you, its owner, to be available, except for calendaring.

## What Is Still Coming

At Microsoft Ignite 2026, Microsoft named these as coming soon: goals as a named feature, voice through the phone's Action button, and computer use on a local Windows PC. Autopilots shared by several people were not rolling out yet. Teach only what the tenant shows on the day.

## Hands-On Demo

[Follow-Through on the Supplier Review](demo-follow-through.md): Autopilot reacts to a supplier mail, then turns a Teams request into a meeting and a decision document, asking before it involves anyone new. 15 minutes.

## Hands-On Lab

[Brief, Schedule, Approve](../../../labs/07-autopilot/02-autopilot-at-work/lab-01-brief-schedule-approve.md): write the brief, add a scheduled and an event routine, and answer an approval. 35 minutes, in pairs.

## Links & Resources

- [Autopilot (Frontier) overview](https://learn.microsoft.com/copilot/autopilot/overview)
- [Work in your Microsoft Edge browser](https://learn.microsoft.com/copilot/autopilot/edge)
- [Application card: Autopilot (Frontier)](https://learn.microsoft.com/copilot/autopilot/microsoft-autopilot-application-card)
- [Ignite BRK202: Automate the Follow-Through with Autopilot](https://ignite.microsoft.com/en-US/sessions/1787856603644001EiOR-1791588098392001CZY7), demo from 00:06:14, Crosscheck at 00:18:29
- [Ignite BRK201: Home, your starting point for work in the Copilot app](https://ignite.microsoft.com/en-US/sessions/1787856603496001EOOR-1791588069487001CY09), plugins at 00:07:10
- [Microsoft Mechanics: Introducing Autopilot](https://www.youtube.com/watch?v=KtV_f3chj9A)
