---
presents: demo-02-meeting-prep-skill.md
budget: 4 min
beats: 4
---

# Present: Build a Reusable Meeting-Prep Skill

**Guide:** [Build a Reusable Meeting-Prep Skill](demo-02-meeting-prep-skill.md) · runs in [Cowork](https://copilot.cloud.microsoft/cowork) and [OneDrive](https://www.office.com/launch/onedrive), after the [follow-up demo](../07-staying-in-control/demo-01-follow-up.md) · each beat links the step holding its prompt

**Initial prompt** (attach `meeting-brief-template.docx` first):

```text
Read meeting-brief-template.docx. This is our house format for a one-page meeting brief. For each section, tell me where that content would come from before a meeting: which calendar entry, which recent emails with the attendee, or which files. Flag any section that needs my judgement rather than data I can pull.
```

### Beat 1: The template mapped to its sources (1 min)

**Navigate:** [Cowork](https://copilot.cloud.microsoft/cowork) > **New task** > **+** > **Upload images and files** · [meeting-brief-template.docx](demo-02-meeting-prep-skill/meeting-brief-template.docx) · [Step 1](demo-02-meeting-prep-skill.md#step-1-map-the-template-to-its-sources)
**What is there:** a table tying the eight sections to calendar, mail or files, with a data-or-judgement column.

### Beat 2: The skill is a folder in OneDrive (1 min)

**Navigate:** [OneDrive](https://www.office.com/launch/onedrive) > **Documents** > **Cowork** > **Skills** > **meeting-prep** · Cowork **Plugins** > **Cowork** > **Added** > **meeting-prep** · [Step 2](demo-02-meeting-prep-skill.md#step-2-author-the-meeting-prep-skill)
**What is there:** the skill page with its description, **Instructions** and **Open in OneDrive**, where `SKILL.md` sits beside the template.

### Beat 3: Run it by name (1 min)

**Navigate:** **New task** · **Workspace** > **Plugins** and **Output** · [Step 3](demo-02-meeting-prep-skill.md#step-3-run-the-skill-for-a-real-meeting)
**What is there:** **meeting-prep** under **Plugins**; `Meeting Brief - Markus Lind - 30 October 2026.docx` under **Output**; no emails from Markus found, placeholders where no source holds the fact.

### Beat 4: Tuned until it fires unnamed (1 min)

**Navigate:** the **Copy file** card · a new task · [Step 4](demo-02-meeting-prep-skill.md#step-4-tune-the-skill-for-reliable-discovery)
**What is there:** **Copy file** (**Medium risk**, **Overwrite** Yes) > **Approve**; a score out of 100; **meeting-prep** under **Plugins** though unnamed; the brief under **Output** with readiness warnings and "Needed" marks.
