# 02 Git and Hosting: The Time Machine

## 🧠 Mental Model: The RPG Save System
Coding without Git is like playing a hard video game without save slots. If you die (break the code), you restart from the beginning.
- **Commit:** A "Save Point". You can always load back to this moment.
- **Repository (Repo):** The entire game save folder.
- **Branch:** An "Alternate Timeline". You can try to fight the boss in this timeline. If you fail, just delete the timeline and go back to the main one.
- **Merge:** Bringing the loot you got in the alternate timeline back to your main game.
- **GitHub:** The "Cloud Save" where you upload your progress so your friends can play too.

## 🪝 Memory Hook
> *"Commit often, Push nightly."*

## 📚 Core Concepts

### 1. The Three States
1.  **Working Directory:** The messy desk where you are currently writing.
2.  **Staging Area (Index):** The box where you put things *ready* to be saved. (`git add`)
3.  **Repository:** The safe. (`git commit`)

### 2. Branching Strategy (Git Flow Lite)
- `main`: The "Production" code. Always working. Do not touch directly.
- `feature/login`: A sandbox where you build the login screen.
- **Pull Request (PR):** Asking the team "Can I merge my sandbox into main?"

### 3. Remote
- `git push`: Upload to cloud.
- `git pull`: Download from cloud.
- `git clone`: Download the whole game for the first time.

## ⚠️ Common Mistakes
- **"Fixed bug" commit messages:** Please describe *what* you fixed. `fix: prevent crash when user is null` is better.
- **Committing Secrets:** Never commit passwords or API Keys. Once they are in git history, they are there forever (even if you delete the file later).
- **Fear of Merge Conflicts:** It's just two people writing on the same line of paper. You just need to decide which sentence stays.

## 📝 Mini Quiz
1.  Which command moves files from "Working Directory" to "Staging Area"?
2.  What is the command to create a new branch called `dev`?
3.  What is a `.gitignore` file used for?
4.  If I delete a file on my computer, is it deleted from GitHub immediately?
5.  What is `origin`?

## 🛠️ Practice Tasks
1.  Type `git status`. Read what it says.
2.  Type `git log --oneline`. See the history of your current project.

## 💭 Reflection
*   Why is "Undo" (Ctrl+Z) not enough? Why do we need Git?
*   Why do we review code (Pull Requests) before merging?