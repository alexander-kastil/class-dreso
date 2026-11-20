# Run Autopilot: Activation, Guardrails and Credits

Autopilot is off until an admin turns it on. This topic covers what admins decide: who gets Autopilot, how much it may spend, what it may reach, and how its work is traced.

## What Admins Decide

| Decision | Where |
| --- | --- |
| Turn Autopilot on, and for whom | Microsoft 365 admin center, **Agents > All agents > Autopilot (Frontier)** |
| How many Copilot Credits it may use | **Copilot > Cost management**, spending policies |
| What it can reach and for how long | Microsoft Entra admin center, Agent 365 |
| Which content it may touch | SharePoint admin center, **Agent Governance** |
| How its actions are watched and audited | Microsoft Purview and Microsoft Defender |

## Activate Autopilot

Activation is a six-step wizard. The full procedure, as run in the class tenant, is in [Autopilot setup](../../../setup/12-autopilot-setup.md).

1. **Select users**: all users, or specific groups.
2. **Spending policy**: when the tenant already uses usage-based billing, the wizard creates an Autopilot spending policy billed to the existing Azure subscription, with no limit until you set one.
3. **Security policy**: a review of the Entra, Purview, Defender and SharePoint protections, which are managed in their own portals.
4. **Accept permissions**: acknowledge that Autopilot may act without asking users to confirm each step.
5. **Memory & personalization**: acknowledge that Autopilot keeps notes about users and that its memory can't be turned off.
6. **Review & activate**: Agent 365 licenses are then assigned automatically to the permitted users.

Before activation, check that the tenant received the Message center post **MC1557730 Autopilot availability in Frontier** and that **Autopilot (Frontier)** shows in the agent list. If it doesn't, the tenant isn't in the rollout yet.

## Pay for It: Copilot Credits

Autopilot, Cowork and Code are billed by use in Copilot Credits. A Copilot license doesn't cover Autopilot's usage.

- Usage-based features stay unusable until IT turns them on and sets a spending policy.
- A spending policy has a scope (a group), a monthly limit for the policy, an optional limit per user, alert thresholds and the models it allows.
- The limit is entered in credits.
- Limits can be set per person (identity-based) or on one agent (resource-based), and costs can be charged back to departments.
- Users only see a "Credits in use" indicator. When the policy runs out, Autopilot stops without telling them.

Microsoft hasn't published a separate price per Autopilot session or action.

## Identity and Access

Every Autopilot is an agent identity in Microsoft Entra, so it can be governed like a user:

- Each identity has an owner and a sponsor, and is created from a blueprint.
- It has its own sign-in logs.
- Entra access packages grant it access to a group or site for a limited time and revoke the access automatically.
- In Agent 365 an admin can block one Autopilot without blocking all of them.

Microsoft's four principles for Autopilot security: identifiable, bounded access, continuous protection, auditable.

## Guardrails on Content

The **Agent Governance** page in the SharePoint admin center sets guardrails once on a blueprint, and they apply to current and future agents:

- **Circle of work**: by default an Autopilot reaches only content around its manager, who can widen it.
- Block external sharing by agents.
- Block a blueprint from specific sites.
- Restrict content discovery.

The guardrails are generally available. The heatmap that shows which agents touch which sites is in public preview.

## Protection and Audit

Purview and Defender defaults apply to Autopilot, including protection against prompt injection. Defender advanced hunting finds an Autopilot's activity by its agent ID, and the Purview audit log records its actions.

## Memory

Autopilot records notes about tasks, priorities and the people it works with. The notes sit in the tenant's OneDrive. Memory can't be turned off, and the memory settings of the Copilot app don't apply. Users can ask their Autopilot what it remembers and correct or remove it.

## Gaps in the Preview

- Autopilot conversations aren't covered by eDiscovery, retention or legal hold.
- Conditional Access policies that target "All users" don't apply to the agent identity.
- Rollout to a tenant can take weeks, and features vary by preview assignment.

## Hands-On Demo

[Activate and Govern Autopilot](demo-activate-and-govern.md): the activation wizard, the spending policy, and one Autopilot followed through Entra, Agent 365 and SharePoint. 15 minutes.

## Hands-On Lab

[Autopilot Readiness Review](../../../labs/07-autopilot/06-autopilot-admin/lab-01-autopilot-readiness-review.md): check your own Autopilot's owner, access, routines, memory and boundaries, and write it down. 25 minutes.

## Links & Resources

- [Configure Autopilot for your organization](https://learn.microsoft.com/copilot/autopilot/admin-configure)
- [Autopilot (Frontier) requirements](https://learn.microsoft.com/copilot/autopilot/requirements)
- [Usage-based billing and cost management for Copilot Credits](https://learn.microsoft.com/copilot/plan/usage-based-billing-overview-copilot-credits)
- [Ignite BRK212: Secure the Follow-Through, Trusting Autopilot at Scale](https://ignite.microsoft.com/en-US/sessions/1787856605173001E6Pi-1791588198567001CV7r), principles at 00:03:11, Entra demo from 00:21:41
- [Ignite OD1930: Agent 365, governing agent access to Microsoft 365 content](https://ignite.microsoft.com/en-US/sessions/1793594384813001xogx-AAAAAAAAAAAAAAAAAAAA), guardrails at 00:05:12
- [Ignite THR865: Navigating AI spend across your organization](https://ignite.microsoft.com/en-US/sessions/1787856577012001Ed9A-1791588086796001CQRF), spending policies from 00:06:09
