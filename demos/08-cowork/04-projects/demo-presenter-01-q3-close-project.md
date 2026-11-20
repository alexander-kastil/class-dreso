---
presents: demo-01-q3-close-project.md
budget: 5 min
beats: 4
---

# Present: Run the Q3 Close as a Project

> **Note:** This demo builds no agent; it creates one Cowork project, **Q3 Close**.

**Guide:** [Run the Q3 Close as a Project](demo-01-q3-close-project.md) · runs in [Cowork](https://copilot.cloud.microsoft/cowork) · each beat links the step holding its prompt

**Initial prompt** (step 1 sends no prompt; attach `q3-sales-by-region.xlsx` and `q3-regional-notes.docx` on the project page first):

```text
Read q3-sales-by-region.xlsx and q3-regional-notes.docx and write the Q3 close summary as a Word document named q3-close-summary.docx.
```

### Beat 1: The rules of the close live in the project (1 min)

**Navigate:** [Cowork](https://copilot.cloud.microsoft/cowork) > hover **Projects** > **+** > **New project** `Q3 Close` > **Create** · **More actions** > **Edit instructions** > **Save** · [Step 1](demo-01-q3-close-project.md#step-1-create-the-q3-close-project-and-its-instructions)
**What is there:** **Q3 Close** under **Projects**; empty **Recent**, **Outputs** and **Project context**; the four instruction lines saved.

### Beat 2: Tasks from the project page follow the rules unasked (2 min)

**Navigate:** **Q3 Close** > **+** > **Upload images and files** · [q3-sales-by-region.xlsx](demo-01-q3-close-project/q3-sales-by-region.xlsx) · [q3-regional-notes.docx](demo-01-q3-close-project/q3-regional-notes.docx) · [Step 2](demo-01-q3-close-project.md#step-2-write-the-q3-close-summary-from-the-project-page) · [Step 3](demo-01-q3-close-project.md#step-3-turn-the-summary-into-a-one-slide-decision-ask)
**What is there:** `q3-close-summary.docx` and `q3-decision-ask.pptx` under **Outputs**, two tasks under **Recent**, decision first and **Open decisions** at the end.

### Beat 3: Outside the project the rules are gone (1 min)

**Navigate:** **New** (no project) > **+** > **Upload images and files** · [Step 4](demo-01-q3-close-project.md#step-4-run-the-same-summary-outside-the-project)
**What is there:** the same summary request in Cowork's default layout; the file is not under **Outputs** of **Q3 Close**.

### Beat 4: Archive keeps the finished close (1 min)

**Navigate:** **Q3 Close** > **More actions** > **Archive** · projects page > **Archived** · [Step 5](demo-01-q3-close-project.md#step-5-archive-the-project-when-the-close-is-done)
**What is there:** **Q3 Close** under **Archived** with both tasks and both files; **Restore** returns it to **Active**.
