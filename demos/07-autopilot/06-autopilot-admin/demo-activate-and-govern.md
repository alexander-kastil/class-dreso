# Activate and Govern Autopilot

An admin who switches Autopilot on without a plan hands every user an agent that acts on its own, keeps notes about people and spends money by the minute. In this demo you show the five places where an admin decides who gets Autopilot, what it may cost and what it may touch, and what users see after activation.

What you practice here: reading Autopilot's admin surface in the order an admin decides, from rollout to guardrails.

Duration: about 40 minutes.

------

Sign in to the [Microsoft 365 admin center](https://admin.cloud.microsoft) with a Global Administrator account of the class tenant. The demo only reads settings: change nothing that would stop the learners' Autopilots.

---

## Exercise 1: Check that the rollout reached the tenant

Autopilot reaches tenants by invitation, a few at a time, so an admin first checks whether the tenant got it at all.

1. Open **Health > Message center** and search for `Autopilot availability in Frontier` (MC1557730). Open it and show the required admin actions at the end: turn on access, set up a Copilot Credits billing policy, enable Autopilot for a security group.
2. Open **Agents > All agents** and search for `Autopilot`.
3. Select **Autopilot (Frontier)** and read its description on the **Details** tab.

**Expected result:** the agent list shows **Autopilot (Frontier)** with the labels **Copilot app** and **Agent template**. Its description says Autopilot is available by invite only, rolls out to eligible Frontier customers from November 17, and needs a Copilot license and usage-based billing. If the template isn't listed, the tenant isn't in the rollout yet.

## Exercise 2: Walk the activation wizard

Activation is one wizard with six steps, and two of them are acknowledgements an admin must read out loud to their security team. In the class tenant Autopilot is already active, so show this exercise on a tenant where the template still shows **Not activated**, or walk it from the step names below.

1. On the template, select **Activate**. The steps are **Select users**, **Spending policy**, **Security policy**, **Accept permissions**, **Memory & personalization** and **Review & activate**.
2. **Select users**: choose **Specific groups** and add one security group. **All users** gives everyone access.
3. **Spending policy**: when the tenant already uses usage-based billing, the wizard creates **Autopilot spending policy**, billed to the existing Azure subscription, with no limit.
4. **Security policy**: scroll through the **Microsoft Entra**, **Microsoft Purview**, **Microsoft Defender** and **SharePoint Online and OneDrive** protections. This step only reviews; each is set in its own portal.
5. **Accept permissions**: read the warning and the checkbox text:

   ```text
   I acknowledge that Autopilot may act without explicit user confirmation
   ```

6. **Memory & personalization**: read the second checkbox text:

   ```text
   I acknowledge that Autopilot retains user information and personalizes interactions
   ```

7. **Review & activate**: show the activation summary and stop before **Activate agent**.

**Expected result:** the summary lists the agent, **Usage-based · Autopilot spending policy**, the users and groups, **Permissions: Accepted** and **Memory & personalization: Acknowledged**. After **Activate agent** the confirmation reads "You activated Autopilot (Frontier) Agent" and says Agent 365 licenses are assigned automatically to permitted users.

## Exercise 3: Cap the credits

Autopilot is billed in Copilot Credits, and it stops without telling the user when its policy runs out, so the limit is the admin's most important number.

1. Open **Copilot > Cost management**, select the **Configuration** tab, then **Spending policies**.
2. Open **Autopilot spending policy**. Show its status, scope, monthly limit and billing subscription.
3. Open **Monthly spending limit** to see the edit panel. Show that the limit is entered as a number of credits, that **Monthly spending limit for users** can cap each person, and that the alert fires at a percentage of the limit (70 by default). Select **Cancel**.
4. Back on **Cost management**, open **Overview** and show the credits used this month.

**Expected result:** the class tenant's policy is **Enabled** for **Copilot Users**, with 2,500 credits a month on pay-as-you-go billing, user limits off and alerts on. The overview shows the month's credits and their cost.

## Exercise 4: See who has Autopilot and what they see

Activation makes Autopilot available to a group, but users get it only when the rollout reaches their accounts. This exercise shows both sides.

1. On **Autopilot (Frontier)**, open the **Users** tab and its **Activated for** sub-tab.
2. Open the **Instances** tab.
3. In a second browser profile signed in as a learner, open [copilot.cloud.microsoft](https://copilot.cloud.microsoft) and select **Autopilot** in the left sidebar.

**Expected result:** **Activated for** lists the group from the wizard. **Instances** lists every Autopilot users created, or "No instances added yet." On the learner side, the **Autopilot** page either offers **Create your Autopilot**, or reads "Autopilot is coming soon. We're getting Autopilot ready for your organization." while the rollout hasn't reached the account.

## Exercise 5: Review the content guardrails and the identities

Each Autopilot gets its own identity and reaches content like a user does, so the last checks are the SharePoint guardrails and the Entra identities.

1. Open the SharePoint admin center and select **Agent governance**. Show its three areas: **Overview**, **Agent access heatmap** and **Settings**.
2. Open **Settings** and read the four guardrails:
   - **Restrict collaboration by agentic users**
   - **Restrict external sharing for agentic users**
   - **Restrict all agentic users from accessing specific sites**
   - **Restrict content discovery**
3. Open the [Microsoft Entra admin center](https://entra.microsoft.com) and go to **Entra ID > Agents**.

**Expected result:** the four guardrails are listed with their current state. In Entra, each Autopilot shows up as an agent identity once a user created one; with no instances, the list has no Autopilot yet.

---

## Summary

You followed the admin's five decisions: whether the tenant has Autopilot, the wizard's two acknowledgements, the credit cap, who has it, and what it may reach. Open the [teaching](readme.md) for why each decision matters.

## Troubleshooting

| What you see | Why |
| --- | --- |
| No **Autopilot (Frontier)** in the agent list | The tenant isn't in the rollout yet. |
| The learner sees "Autopilot is coming soon" | Activation is done, but the rollout hasn't reached that account. Check again later. |
| **Instances** stays empty | No user has created an Autopilot yet. |
