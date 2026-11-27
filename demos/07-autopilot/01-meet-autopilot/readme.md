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
| Memory | It keeps conversation memory, personal memory about you and workspace memory for its work, saved in your OneDrive. Memory can't be turned off in this release. |
| Computer | A Microsoft-managed cloud computer that is separate from your device and can't reach your local folders or apps. Where your admin enables it, it can also work in your own Microsoft Edge. |
| Workspace | **Automations** under its name and **Plugins** in the left navigation, and a management panel with **Overview**, **Activity**, **Routines** and **Settings**. |

Some operations use Autopilot's own identity and others use your access on your behalf: it may read your calendar with your permissions and write to a coworker under its own name. Either way, Autopilot doesn't expand the data you can access. Microsoft's guidance at Ignite: "Treat Autopilot like an employee."

## Where You Work with It

- **Microsoft Copilot**, on the web at [copilot.cloud.microsoft](https://copilot.cloud.microsoft) or in the desktop app: select your Autopilot's name on the **Home** tab. Nothing is installed.
- **Microsoft Teams**: a private one-on-one chat for updates, questions and approvals. At your request it also messages coworkers in Teams, follows up on commitments and helps schedule meetings, with approval.
- **Outlook**: it has its own mailbox and calendar next to yours.
- **Mobile**: the Microsoft 365 Copilot, Teams and Outlook apps on iOS and Android.

## Personal Teammate or Shared Teammate

Autopilot works for one person. An agent with its own account, built in Copilot Studio, works for a team's process (see [Agent Accounts](../03-agent-accounts/readme.md)). Place Autopilot in the Agent Landscape places both among the other Copilot experiences.

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

- Autopilot is a Frontier preview and is off by default. Availability is initially limited to select eligible Frontier customers in the United States, with new Frontier tenants rolling out over time. Autopilot is optimized for English, and features can vary by preview assignment.
- The accountable user needs a Microsoft 365 Copilot license, and the organization turns on usage-based billing. A Copilot license doesn't include Autopilot usage: it is billed in Copilot Credits through a spending policy that must cover the user.
- The admin enables Frontier, creates the spending policy and activates Autopilot for a group (see [Run Autopilot](../06-autopilot-admin/readme.md) and [Autopilot setup](../../../setup/12-autopilot-setup.md)). Frontier enrollment alone doesn't make Autopilot available.
- The tenant needs three security capabilities: Microsoft Entra Agent ID (provisioned automatically), an isolated execution environment (Microsoft local, MXC, licensed with Microsoft Intune Plan 1 or Microsoft 365 E3) and Microsoft 365 audit logs.
- Creating an Autopilot takes 10 to 30 minutes of provisioning. Email and Teams tell you when it is ready.

## Hands-On Demo

[Place the Teammate on the Map](demo-place-teammate-on-map.md): one canteen request through Chat, Cowork and Autopilot, and where each one stops. 25 minutes.

## Hands-On Lab

[Create Your Autopilot](../../../labs/07-autopilot/01-meet-autopilot/lab-01-create-your-autopilot.md): name it, choose its starter routines and confirm the profile it inferred. 10 minutes plus provisioning.

## Links & Resources

- [Autopilot (Frontier) overview](https://learn.microsoft.com/copilot/autopilot/overview)
- [Get started with Autopilot (Frontier)](https://learn.microsoft.com/copilot/autopilot/get-started)
- [Autopilot (Frontier) requirements](https://learn.microsoft.com/copilot/autopilot/requirements)
- [Autopilot (Frontier) FAQ](https://learn.microsoft.com/copilot/autopilot/faq)
- [Microsoft Mechanics: Introducing Autopilot](https://www.youtube.com/watch?v=KtV_f3chj9A)
- [Ignite BRK202: Automate the Follow-Through with Autopilot](https://ignite.microsoft.com/en-US/sessions/1787856603644001EiOR-1791588098392001CZY7)
- [Ignite BRK201: Home, your starting point for work in the Copilot app](https://ignite.microsoft.com/en-US/sessions/1787856603496001EOOR-1791588069487001CY09)
- [Introducing the new Copilot with Home, Code and Autopilot](https://blogs.microsoft.com/blog/2026/09/25/introducing-the-new-copilot-with-home-code-and-autopilot/)
