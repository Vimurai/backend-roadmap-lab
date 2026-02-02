# ⚔️ Challenges: The Time Lord

## Easy: The Save Point
1.  Initialize a new git repo in a temp folder (`git init`).
2.  Create `file1.txt`.
3.  Add it to staging (`git add file1.txt`).
4.  Commit it (`git commit -m "Initial commit"`).
5.  **Challenge:** Change the text in `file1.txt`. Run `git status`. What does it say?

## Easy: The Ignore
1.  Create a file named `secret.key`.
2.  Create a file named `.gitignore`.
3.  Add `*.key` to the `.gitignore`.
4.  Run `git status`.
5.  **Challenge:** Ensure git *does not* see `secret.key`.

## Easy: The History
1.  Make 3 different commits changing `file1.txt`.
2.  Run `git log`.
3.  **Challenge:** Find the "Hash" (the weird code like `a1b2c3d`) of the first commit.

## Medium: The Multiverse (Branching)
1.  Create a branch `feature-x` (`git checkout -b feature-x`).
2.  Change `file1.txt` to say "I am in the multiverse".
3.  Commit it.
4.  Switch back to main (`git checkout main`).
5.  **Challenge:** Open `file1.txt`. The text should be back to the old version. Magic!

## Medium: The Merge
1.  Go back to `main`.
2.  Merge the feature (`git merge feature-x`).
3.  **Challenge:** Verify `file1.txt` now has the new text. Delete the branch `feature-x`.

## Medium: The Conflict (Simulation)
1.  Create branch `blue`. Change line 1 of `file.txt` to "Blue". Commit.
2.  Go back to `main`.
3.  Create branch `red`. Change line 1 of `file.txt` to "Red". Commit.
4.  Merge `blue` into `main`. (Success).
5.  Merge `red` into `main`. (FAIL!).
6.  **Challenge:** Fix the conflict manually in the file. `git add`. `git commit`.

## Hard: The Time Travel (Reset)
1.  Make a "Bad Commit" that deletes everything.
2.  Realize your mistake.
3.  **Challenge:** Use `git reset --hard HEAD~1` to travel back in time 1 step. Verify files are back.

## Hard: The Stash
1.  Start working on a file. Don't commit.
2.  Pretend your boss needs you to fix a bug on another branch ASAP.
3.  **Challenge:** Use `git stash` to hide your work. Switch branches. Switch back. `git stash pop`.

## Boss Challenge: "The GitHub Flow" 🐙
**Goal:** Simulate a real job.
1.  Fork this repository (if you are reading this on GitHub).
2.  Clone your fork.
3.  Create a branch `add-my-name`.
4.  Create a file `roadmaps/backend/csharp/00-orientation/class-list.md` and add your name.
5.  Push the branch to origin (`git push -u origin add-my-name`).
6.  Go to GitHub UI.
7.  **Task:** Create a Pull Request (PR) from your branch to your main branch. Merge it via the UI. Pull the changes locally (`git pull`).