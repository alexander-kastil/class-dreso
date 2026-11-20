# Autopilot setup

Status checked on 2026-11-20: Autopilot (Frontier) is activated in the class tenant for the **Copilot Users** group, with its own spending policy capped at 2,500 Copilot Credits per month.

Autopilot is the personal, always-on agent in Microsoft Copilot used in [Module 8](../demos/07-autopilot/readme.md). Nothing is installed on a device: an admin activates it in the Microsoft 365 admin center, and each user then creates their own Autopilot in Microsoft Copilot.

## Prerequisites

| Item | Where to check |
| --- | --- |
| The rollout reached the tenant | The Message center has **MC1557730 Autopilot availability in Frontier**, and **Agents > All agents** lists **Autopilot (Frontier)** |
| Copilot Frontier is on for the users | **Copilot > Settings > Copilot Frontier** |
| A Microsoft 365 Copilot license for every user who gets an Autopilot | **Billing > Licenses** |
| Usage-based billing with an Azure subscription | **Copilot > Cost management**, see [Spending policy](02-spending-policy-m365.md) |
| Intune Plan 1 or Microsoft 365 E3 for the isolated runtime | **Billing > Licenses** |

If **Autopilot (Frontier)** is not in the agent list, the tenant is not in the rollout yet, and there is no way to force it.

## Activate Autopilot

1. In the Microsoft 365 admin center, open **Agents > All agents > Autopilot (Frontier)** and select **Activate**. The wizard has six steps.
2. **Select users**: choose **Specific groups** and add the group whose members get Autopilot (class tenant: **Copilot Users**). **All users** gives everyone in the organization access.
3. **Spending policy**: when the tenant already uses usage-based billing, the wizard creates **Autopilot spending policy** for **Microsoft Copilot - Autopilot**, billed to the existing Azure subscription, with no limit. Select **Customize policy > Monthly spending limit > Set a monthly limit** and enter the limit in credits, not euros. The class tenant uses 2,500 credits for a budget of 25 €. Leave the per-user limit off, keep the 70 % alert to the admin, then select **Save changes** and **Close**. When the limit is reached, Autopilot stops without telling the user.
4. **Security policy**: review only. The Entra, Purview, Defender and SharePoint protections are set in their own portals.
5. **Accept permissions**: tick the acknowledgement that Autopilot may act without explicit user confirmation (send messages, share information, change content, delete items).
6. **Memory & personalization**: tick the acknowledgement. Memory can't be turned off, and the memory settings of the Copilot app don't apply.
7. **Review & activate**: select **Activate agent**. The confirmation says Agent 365 licenses are assigned automatically to permitted users.

## Create your Autopilot

Each user does this once.

1. Open [copilot.cloud.microsoft](https://copilot.cloud.microsoft) or the Microsoft Copilot desktop app with the work account. No app update or install is needed.
2. On the **Home** tab, select **Create your Autopilot**, choose a name and appearance, and accept or reject the suggested starter routines.
3. Provisioning takes 10 to 30 minutes. An email and a Teams notification arrive when it is ready. Review the profile it inferred and select **Looks good**.
4. Work with it in Microsoft Copilot (its name on the **Home** tab), in a private Teams chat, and on mobile in the Microsoft 365 Copilot, Teams or Outlook app.
