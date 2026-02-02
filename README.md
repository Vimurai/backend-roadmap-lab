# Backend Roadmap Lab 🧪

> **Master Backend Engineering through Experiments, Analogies, and Code.**

Welcome to the **Backend Roadmap Lab**. This is not a book, and it is not a video tutorial. It is a **flight simulator** for backend engineers. You will learn by fixing broken code, passing failing tests, and building systems from the ground up.

---

## 📑 Table of Contents
- [The Learning Philosophy](#-the-learning-philosophy)
- [How This Repo is Structured](#-how-this-repo-is-structured)
- [Getting Started](#-getting-started)
- [Study Plans](#-study-plans)
- [Resetting Your Progress](#-resetting-your-progress)
- [Contributing & New Languages](#-contributing--new-languages)
- [Disclaimer](#-disclaimer)

---

## 🧠 The Learning Philosophy

We believe in **"Test-Driven Learning"**. Passive reading is the enemy of retention.

1.  **Small Steps**: Complex systems are just many simple pieces glued together. We break them down.
2.  **Test-First**: You know you're done when the red text turns green.
3.  **Analogy Anchors**: We explain abstract concepts using real-world objects (e.g., *Interfaces are like power outlets*, *Databases are like filing cabinets*).
4.  **Reflection**: After every module, you pause to understand *why* it worked.

---

## 📂 How This Repo is Structured

The curriculum is organized by **Role** > **Language** > **Module**.
Currently active: `roadmaps/backend/csharp/`

### 🏗️ Tracks
- **Main Track (00-19):** Covers industry-standard backend topics (APIs, Databases, Auth, etc.).
- **Algorithms Track (`_algorithms/`):** Parallel track for data structures and algorithmic thinking.

Inside every module (e.g., `03-csharp-language-core`), you will find:

| File / Folder | Purpose |
| :--- | :--- |
| `lesson.md` | **Read this first.** Contains the theory, the "Analogy Anchor", and the big picture. |
| `challenges.md` | **Your Quest Log.** Step-by-step instructions on what code to write. |
| `src/` | **The Workbench.** Contains code stubs, broken logic, and `TODO` comments. This is where you work. |
| `tests/` | **The Judge.** A test suite that fails initially. Your goal is to make all tests pass. |

---

## 🚀 Getting Started

### Prerequisites
- **Git** installed.
- **.NET SDK 8.0+** (for the C# track).
- A code editor (VS Code, Rider, or Visual Studio).

### Step-by-Step
1.  **Clone the Lab:**
    ```bash
    git clone https://github.com/your-org/backend-roadmap-lab.git
    cd backend-roadmap-lab
    ```

2.  **Pick Your Track:**
    Navigate to the C# track (our flagship curriculum):
    ```bash
    cd roadmaps/backend/csharp
    ```

3.  **Start Module 00:**
    Go to `00-orientation`, read the `lesson.md`, and run the tests to ensure your environment is ready.
    ```bash
    cd 00-orientation
    dotnet test
    ```

---

## 📅 Study Plans

Consistency beats intensity. Choose the pace that fits your life.

### Option A: The "Professional" (Weekdays)
*Ideal for those treating this as a nightly class.*

*   **Time:** 2 Hours / Day (Mon-Fri)
*   **Routine:**
    *   **Hour 1 (Theory):** Read `lesson.md`. Don't just skim; understand the analogy. Research the terms you don't know.
    *   **Hour 2 (Lab):** Open `challenges.md`. Attempt the code. Run tests frequently.
*   **Goal:** Complete 1-2 modules per week.

### Option B: The "Weekend Warrior"
*Ideal for those with busy work weeks.*

*   **Saturday (Deep Work):** 4 Hours. Tackle the heavy implementation parts of a module.
*   **Sunday (Review):** 2 Hours. Review your code. Refactor it. Read the `lesson.md` again to see if it makes more sense now.

### Detailed Curriculum
See [docs/STUDY-PLAN-1-YEAR.md](./docs/STUDY-PLAN-1-YEAR.md) for a complete 12-month breakdown.

---

## 🔄 Resetting Your Progress

Stuck? Messed up the files? Want to practice the same module again?
We provide scripts to revert the `src/` files to their original state without losing your git history.

**Bash (Linux/macOS):**
```bash
./scripts/reset.sh
```

**PowerShell (Windows):**
```powershell
./scripts/reset.ps1
```

**What this does:**
1.  Asks for confirmation (unless you pass `--force`).
2.  Deletes the current `src/`, `tests/`, `bin/` and `obj/` folders.
3.  Copies the fresh "Starter State" (with empty TODOs) back into your folder.

---

## 🤝 Contributing & New Languages

This lab is designed to be language-agnostic in structure.

### Adding a New Language (e.g., Python, Go)
1.  Copy the folder structure pattern: `roadmaps/backend/<language>/`.
2.  Ensure you keep the standard numbered folders (`01-internet`, `02-git`, etc.) so the curriculum aligns across languages.
3.  Translate the `src` stubs and `tests` into the target language.
4.  Adapt `lesson.md` code snippets.

See [CONTRIBUTING.md](./CONTRIBUTING.md) for style guides.

---

## ⚠️ Disclaimer

**This is a Learning Lab, NOT a Production Template.**

To make concepts learnable, we sometimes:
*   Simplify security models.
*   Hardcode configurations that should be environment variables.
*   Omit complex error handling that would obscure the core lesson.

**Do not copy-paste this code into a real banking application.** Use this repo to learn the *concepts*, then apply them using your company's production standards.
