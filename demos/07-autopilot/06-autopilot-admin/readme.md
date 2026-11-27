# Run Autopilot: Activation, Guardrails and Credits

Autopilot is off until an admin turns it on. This topic covers what admins decide: who gets Autopilot, how much it may spend, which model processes its work, what it may share, and what it remembers. How its identity is governed and audited is in Govern Autopilot Like an Employee.

## What Admins Decide

| Decision | Where |
| --- | --- |
| Turn Autopilot on, and for whom | Microsoft 365 admin center, **Agents > All agents > Autopilot (Frontier)** |
| How many Copilot Credits it may use | **Copilot > Cost management > Configuration > Spending policies** |
| Which model and provider process its work | **Copilot > Settings > AI providers operating as Microsoft subprocessors** |
| What it can reach and for how long | Microsoft Entra admin center, Agent 365 |
| Which content it may share | SharePoint admin center, **Agent governance** |
| How its actions are watched and audited | Microsoft Purview and Microsoft Defender |

## Activate Autopilot

Three steps are required, and enabling Frontier alone doesn't make Autopilot available: enroll the users in Frontier (**Copilot > Settings > View all**, search `Frontier`, **Copilot Frontier**), cover them with a spending policy that includes Autopilot, and activate the agent. Before you start, confirm that the users have Microsoft 365 Copilot licenses and that the tenant has the required security capabilities: Microsoft Entra Agent ID, the isolated execution environment (Microsoft local, MXC, with Microsoft Intune Plan 1 or Microsoft 365 E3) and Microsoft 365 audit logs.

Activation is a wizard on **Agents > All agents > Autopilot (Frontier) > Activate**. The full procedure, as run in the class tenant, is in [Autopilot setup](../../../setup/12-autopilot-setup.md).

1. **Select users**: all users, or specific groups. Keep this scope aligned with the spending policy.
2. **Spending policy**: pick the Autopilot spending policy, or keep the new one the wizard suggests and select **Customize policy** to set limits and the billing method.
3. **Security policy**: a review of the default Microsoft Entra, Microsoft Purview and Microsoft Defender protections. They're managed in each product and might not be turned on, so check their status there.
4. **Accept permissions**: acknowledge that Autopilot can act without per-step confirmation.
5. **Memory & personalization**: review the agent's memory capabilities and user controls.
6. **Review & activate**: confirm and select **Activate agent**. You don't select or assign a license in the wizard; the confirmation says Agent 365 licenses are assigned automatically to permitted users.

Before activation, check that the tenant received the Message center post **MC1557730 Autopilot availability in Frontier** and that **Autopilot (Frontier)** shows in the agent list. If it doesn't, the tenant isn't in the rollout yet.

## See and Stop Instances

On **Autopilot (Frontier)**, the **Instances** tab lists the Autopilots users created. Removing a user from the activation scope doesn't remove an Autopilot they already have. To stop one, remove the user from the spending policy and then block or delete the instance; a block can take about an hour to reach Autopilot, and work on the owner's behalf can continue longer.

## Pay for It: Copilot Credits

Autopilot, Cowork and Code are billed by use in Copilot Credits. A Copilot license doesn't include Autopilot usage.

- Usage-based features stay unusable until IT turns on usage-based billing and covers the users with a spending policy.
- The policy for Autopilot has an **Identity** scope (all users or groups), **Autopilot** selected under **Microsoft Copilot**, a monthly limit, a per-user limit or both, optional email alerts and a billing method: an Azure subscription for pay-as-you-go or prepaid Copilot Credits.
- The limit is entered in credits. When a user is in more than one policy, the one with the highest limit applies.
- Users only see a **Credits in use** indicator, with no count of credits used or remaining. When the policy runs out, Autopilot stops its routines, its monitoring and its answers to new requests, without telling the user.

Microsoft hasn't published a separate price per Autopilot session or action. Track the usage in **Copilot > Cost management**.

## Model and Data Processing

Autopilot runs on GPT-6.1 Sol, provided by OpenAI operating as a Microsoft subprocessor. If the organization turns OpenAI off in **AI providers operating as Microsoft subprocessors**, Autopilot uses GPT-5.6 Sol hosted in Azure OpenAI instead. Users can't switch the model, and there is no model control for Autopilot.

Before you enable Autopilot broadly, check that processing by OpenAI meets your data residency and EU Data Boundary requirements. If it doesn't, turn the provider off and Autopilot falls back to the model in Azure OpenAI.

## Guardrails on Content

The **Agent governance** page in the SharePoint admin center sets content guardrails for agentic users, per blueprint or for all of them, and they apply to current and future agents:

- **Restrict collaboration by agentic users**: an agentic user can share sites and content only with its manager, the only member of its circle of work in this release. The guardrail is off by default, isn't retroactive and is in preview.
- **Restrict external sharing for agentic users**.
- **Restrict all agentic users from accessing specific sites**.
- **Restrict content discovery**.

The heatmap that shows which agents touch which sites is in public preview.

## Memory

Autopilot keeps conversation memory, personal memory about its owner and workspace memory for its work, stored with its sessions in a file named `lobster.repo` in the owner's OneDrive. Memory can't be turned off in this release, and the Microsoft 365 Copilot personalization settings don't apply.

Users review it under **Review what [name] knows** in the Autopilot panel, and correct, delete or export memories by asking in chat. Deleting a conversation doesn't delete a memory saved from it. For an approved compliance or privacy request, an admin can export a copy of a user's memories and sessions with Microsoft's export script, but can't delete them on the user's behalf.

## Hands-On Demo

[Activate and Govern Autopilot](demo-activate-and-govern.md): the activation wizard, the spending policy, and one Autopilot followed through Entra, Agent 365 and SharePoint. 40 minutes.

## Hands-On Lab

[Autopilot Readiness Review](../../../labs/07-autopilot/06-autopilot-admin/lab-01-autopilot-readiness-review.md): check your own Autopilot's owner, access, routines, memory and boundaries, and write it down. 15 minutes.

## Links & Resources

- [Configure Autopilot for your organization](https://learn.microsoft.com/copilot/autopilot/admin-configure)
- [Autopilot (Frontier) requirements](https://learn.microsoft.com/copilot/autopilot/requirements)
- [Usage-based billing and cost management for Copilot Credits](https://learn.microsoft.com/copilot/plan/usage-based-billing-overview-copilot-credits)
- [Restrict content collaboration by agentic users (preview)](https://learn.microsoft.com/sharepoint/agentic-users-governance-restrict-share-to-set-users)
- [Ignite BRK212: Secure the Follow-Through, Trusting Autopilot at Scale](https://ignite.microsoft.com/en-US/sessions/1787856605173001E6Pi-1791588198567001CV7r), principles at 00:03:11, Entra demo from 00:21:41
- [Ignite OD1930: Agent 365, governing agent access to Microsoft 365 content](https://ignite.microsoft.com/en-US/sessions/1793594384813001xogx-AAAAAAAAAAAAAAAAAAAA), guardrails at 00:05:12
- [Ignite THR865: Navigating AI spend across your organization](https://ignite.microsoft.com/en-US/sessions/1787856577012001Ed9A-1791588086796001CQRF), spending policies from 00:06:09
