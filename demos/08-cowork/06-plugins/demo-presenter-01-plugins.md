---
presents: demo-01-plugins.md
budget: 4 min
beats: 3
---

# Present: Extend Cowork with a Community Plugin

**Guide:** [Extend Cowork with a Community Plugin](demo-01-plugins.md) · runs in [Cowork](https://copilot.cloud.microsoft/cowork) · each beat links the step holding its prompt

**Initial prompt** (after the install, attach `client-intake.docx` first):

```text
Read client-intake.docx. Using the clinical-nutrition skill, draft a nutrition assessment for this client. Calculate estimated energy and protein needs and show your assumptions. Interpret the labs, including A1C, fasting glucose, the lipid panel, and albumin. Identify the condition-specific considerations for type 2 diabetes and hypertension, and note any priorities a dietitian should weigh first.
```

### Beat 1: The plugin installs as a zip upload (1 min)

**Navigate:** [dietitian on GitHub](https://github.com/alexclowe/awesome-copilot-cowork-plugins/tree/main/dietitian) · Cowork **Plugins** > **Cowork** > **Add** > **Upload** · **Publish "dietitian"** > **Only you** > **Publish** · [Step 1](demo-01-plugins.md#step-1-install-the-dietitian-plugin)
**What is there:** **dietitian** first under **Added**, **Created by The AI Career Lab**, **Enable dietitian** on, **Skills** listing `clinical-nutrition` and `dietary-communication`.

### Beat 2: Two plugin skills, two audiences (1.5 min)

**Navigate:** **New task** > **+** > **Upload images and files** · [client-intake.docx](demo-01-plugins/client-intake.docx) · **Workspace** > **Plugins** · [Step 2](demo-01-plugins.md#step-2-draft-the-nutrition-assessment) · [Step 3](demo-01-plugins.md#step-3-turn-the-assessment-into-a-client-handout)
**What is there:** **Reviewed custom skill dietitian (clinical-nutrition)**, then **dietitian (dietary-communication)**, both under **Plugins**: a clinical assessment, then a plain-language handout.

### Beat 3: The built-in Word skill compiles the packet (1.5 min)

**Navigate:** **Workspace** > **Output** > the file preview · [Step 4](demo-01-plugins.md#step-4-compile-the-client-nutrition-packet) · [Step 5](demo-01-plugins.md#step-5-watch-installed-plugin-skills-behave-like-built-in-ones)
**What is there:** the background task **Build nutrition packet document** (about ten minutes); `Client Nutrition Packet - NUT-2041.docx` with the bold DRAFT ONLY line on top; **Word** beside both dietitian skills under **Plugins**.
