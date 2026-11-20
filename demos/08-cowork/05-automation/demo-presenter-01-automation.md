---
presents: demo-01-automation.md
budget: 4 min
beats: 4
---

# Present: Automate a Weekly Status Report

**Guide:** [Automate a Weekly Status Report](demo-01-automation.md) · runs in [Cowork](https://copilot.cloud.microsoft/cowork) and [OneDrive](https://www.office.com/launch/onedrive) · each beat links the step holding its prompt

**Initial prompt** (attach `weekly-status-template.docx` first):

```text
Read weekly-status-template.docx. This is our house format for the weekly regional status report. For each section, tell me where that content would come from in a normal week: which of my emails, meetings, or figures would fill it. Flag any section that needs a judgement call rather than just pulling data.
```

### Beat 1: The template becomes a recipe (1 min)

**Navigate:** [Cowork](https://copilot.cloud.microsoft/cowork) > **New task** > **+** > **Upload images and files** · [weekly-status-template.docx](demo-01-automation/weekly-status-template.docx) · [Step 1](demo-01-automation.md#step-1-turn-the-template-into-a-recipe)
**What is there:** a source map per section; Highlights, Blockers, Next week and Asks flagged as judgement.

### Beat 2: The skill is written in OneDrive (1 min)

**Navigate:** [OneDrive](https://www.office.com/launch/onedrive) > **My files** > **Documents** > **Cowork** > **Skills** > **Create or upload** > **Folder**, then **Markdown document** · Cowork **Plugins** > **Cowork** > **Added** · [Step 2](demo-01-automation.md#step-2-author-the-custom-skill)
**What is there:** `Untitled` renamed to `SKILL` in the header; after about six minutes **weekly-status-report** under **Added** ("Created by you") and under `/` > **Skills** > **Custom skills**.

### Beat 3: One run by hand before the schedule (1 min)

**Navigate:** **New task** (effort **Light**) · **Workspace** > **Output** · [Outlook Drafts](https://outlook.office.com/mail/drafts) · [Step 3](demo-01-automation.md#step-3-run-the-skill-once-before-you-trust-it)
**What is there:** **Reviewed custom skill Weekly status report**; a one-page Word report under **Output**; a **Saved to drafts** card with the "Hi Elena" draft; "Nothing has been sent."

### Beat 4: The schedule lives under Automations (1 min)

**Navigate:** the **Create recurring task?** card · left nav **Automations** > **Active** > the row's **...** · [Step 4](demo-01-automation.md#step-4-put-it-on-a-schedule)
**What is there:** **Repeat** Weekly, Friday, 3:00 PM, **Description**, **Run once now** (clear it), **Schedule**; the row reads "Every week on Friday at 3:00 PM"; **...** > **Pause** after the demo.
