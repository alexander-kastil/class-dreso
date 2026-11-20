# Meet Autopilot

Autopilot is the personal, always-on agent in Microsoft Copilot. You describe the outcome you want, the sources it should use and the boundaries for its actions, and it keeps working in the cloud while your laptop is off. Each person can have one Autopilot.

## Four Ways to Work with Copilot

Microsoft presents Copilot as four work modes. Autopilot is the last step: the one that keeps going without the next prompt.

| Mode | What it does | When it stops |
| --- | --- | --- |
| Chat | Answers a question | After the answer |
| Cowork | Carries one multi-step task to a finished deliverable | When the deliverable is done |
| Code | Builds a tool or app from plain language | When the tool works |
| Autopilot | Keeps ongoing work moving toward goals, on a schedule or when something happens | When you stop it |

Microsoft introduced Home, Code and Autopilot together on 2026-09-25. Autopilot was called Scout before that, and Microsoft Ignite 2026 showed the four modes as one ladder.

## What Makes Autopilot a Teammate

| Property | What it means |
| --- | --- |
| Identity | Its own Microsoft Entra Agent ID, email address, Teams @-mention handle and OneDrive files. Coworkers see its name and look. |
| Memory | It keeps your preferences and its working context across days and weeks. The memory sits in your organization's OneDrive and can't be turned off. |
| Computer | A cloud computer that is separate from your device. It can use a browser there, and optionally your own Microsoft Edge. |
| Workspace | Routines, an **Activity** list, plugins and skills, all in a management panel in Copilot. |

While you chat with it, Autopilot acts as you. When it works on its own, it acts under its own identity. Microsoft's guidance at Ignite: "Treat Autopilot like an employee, not like an agent."

## Where You Work with It

- **Microsoft Copilot**, on the web at [copilot.cloud.microsoft](https://copilot.cloud.microsoft) or in the desktop app: select your Autopilot's name on the **Home** tab. Nothing is installed.
- **Microsoft Teams**: a private one-on-one chat for updates, questions and approvals. Coworkers can also @-mention it in chats and channels.
- **Outlook**: it has its own mailbox and calendar next to yours.
- **Mobile**: the Microsoft 365 Copilot, Teams and Outlook apps on iOS and Android.

## Personal Teammate or Shared Teammate

Autopilot works for one person. An agent with its own account, built in Copilot Studio, works for a team's process (see [Agent Accounts](../03-agent-accounts/readme.md)).

| | Autopilot | Agent with an account |
| --- | --- | --- |
| Works for | One person | A team or process |
| Set up by | The user, in plain language | A maker in Copilot Studio |
| After a reorg | Goes with its owner | Stays with the work |
| Typical job | Follow-through on your own commitments | A shared review, intake or standup |

As the Copilot Studio team put it at Ignite: "the key difference is personal productivity versus a shared business process."

## What People Hand Their Autopilot

| Scenario | What you hand it |
| --- | --- |
| Meeting prep | Brief me before each customer meeting with open items and recent mail |
| Inbox triage | Sort supplier mail each morning and draft the replies that need me |
| Morning briefing | At 08:00, tell me what changed overnight on my projects |
| Overnight report | Collect the day's numbers and have a summary ready when I start |
| Monthly business review | Gather the figures and draft the deck the week before the review |
| Expense entry | Find the receipts in my inbox and fill in the expense report |
| Self-review | Collect what I delivered this quarter from mail, chats and documents |

## Availability and Prerequisites

- Autopilot is a Frontier preview and is off by default. The rollout to Frontier tenants started on 2026-11-17, at first for eligible customers in the United States and optimized for English.
- Each user needs a Microsoft 365 Copilot license. The admin enables Frontier, creates a spending policy for Copilot Credits and activates Autopilot for a group (see [Run Autopilot](../06-autopilot-admin/readme.md) and [Autopilot setup](../../../setup/12-autopilot-setup.md)).
- Creating an Autopilot takes 10 to 30 minutes of provisioning. Email and Teams tell you when it is ready.

## Hands-On Demo

[Place the Teammate on the Map](demo-place-teammate-on-map.md): one canteen request through Chat, Cowork and Autopilot, and where each one stops. 10 minutes.

## Hands-On Lab

[Create Your Autopilot](../../../labs/07-autopilot/01-meet-autopilot/lab-01-create-your-autopilot.md): name it, choose its starter routines and confirm the profile it inferred. 20 minutes plus provisioning.

## Links & Resources

- [Autopilot (Frontier) overview](https://learn.microsoft.com/copilot/autopilot/overview)
- [Get started with Autopilot (Frontier)](https://learn.microsoft.com/copilot/autopilot/get-started)
- [Autopilot (Frontier) requirements](https://learn.microsoft.com/copilot/autopilot/requirements)
- [Microsoft Mechanics: Introducing Autopilot](https://www.youtube.com/watch?v=KtV_f3chj9A)
- [Ignite BRK202: Automate the Follow-Through with Autopilot](https://ignite.microsoft.com/en-US/sessions/1787856603644001EiOR-1791588098392001CZY7)
- [Ignite BRK201: Home, your starting point for work in the Copilot app](https://ignite.microsoft.com/en-US/sessions/1787856603496001EOOR-1791588069487001CY09)
- [Introducing the new Copilot with Home, Code and Autopilot](https://blogs.microsoft.com/blog/2026/09/25/introducing-the-new-copilot-with-home-code-and-autopilot/)
