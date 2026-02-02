# GEMINI.md - Backend Roadmap Lab

## Project Overview
The **Backend Roadmap Lab** is a hands-on, test-driven learning environment designed to help engineers master backend development through practical experimentation and real-world analogies. The project is structured as a series of modules, each containing theory, implementation challenges, and a suite of tests that must be passed to complete the lesson.

The primary track is currently focused on **C#** and **.NET**, with a parallel track for **Algorithms**.

### Main Technologies
- **Runtime:** .NET 8.0+
- **Language:** C#
- **Testing Framework:** xUnit
- **Project Type:** Console/Library Labs (Lab.csproj)

## Project Structure
The repository is organized by `Role > Language > Module`:
- `roadmaps/backend/csharp/`: The main curriculum modules (00-19).
- `roadmaps/backend/csharp/_algorithms/`: Data structures and algorithmic challenges.
- `roadmaps/backend/csharp/_shared/starter-state/`: Contains the original state of all labs for reset purposes.
- `docs/`: Learning philosophies, style guides, and long-term study plans.
- `scripts/`: Utility scripts for resetting the lab environment.

### Module Anatomy
Inside each module (e.g., `03-csharp-language-core`):
- `lesson.md`: Theory and core concepts (Analogy Anchors).
- `challenges.md`: Step-by-step instructions for the lab.
- `src/`: The student's workspace containing broken code or `TODO` stubs.
- `tests/`: xUnit tests that validate the student's implementation.

## Building and Running
All lab actions are performed via the .NET CLI within a module's directory.

### Run Tests
To run the tests for a specific module:
```bash
cd roadmaps/backend/csharp/<module-name>
dotnet test
```

### Build Project
To ensure the project compiles:
```bash
dotnet build
```

### Reset Progress
To revert all labs to their initial "starter" state (WARNING: this deletes your work in `src/` and `tests/`):
```bash
./scripts/reset.sh          # Linux/macOS
./scripts/reset.ps1         # Windows
```

## Development Conventions

### Coding Style
- **Naming:** Follow standard Microsoft .NET naming conventions (PascalCase for classes/methods, camelCase for variables).
- **Typing:** Use `var` when the type is obvious from the right-hand side.
- **Nullability:** Nullable reference types are enabled (`<Nullable>enable</Nullable>`).

### Educational Standards
- **Analogy Anchors:** Always explain complex backend concepts using real-world analogies (e.g., "Interfaces are like power outlets").
- **Test-Driven Learning:** Learners should start with red (failing) tests and work until they are green.
- **Scaffolding:** Use `// TODO` comments to mark implementation areas.
- **Exceptions:** Unimplemented stubs should throw `new NotImplementedException();`.

### Documentation Style
- **Purpose:** Focus on *Why* something is done, especially in the `lesson.md` and code comments.
- **Guidance:** Prefer hints in `challenges.md` over providing direct solutions in the code.
