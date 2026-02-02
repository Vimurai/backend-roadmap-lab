# ⚔️ Challenges: Setup & Survival

## Easy: The Navigator
1.  Open your terminal.
2.  Print your current location (`pwd` or `cd`).
3.  List all files, including hidden ones (`ls -a` or `dir /a`).

## Easy: The Architect
1.  Create a directory tree: `project/src/tests`.
2.  Create an empty file inside `src` called `main.code` (use `touch` or `echo`).

## Easy: The Cleaner
1.  Rename `main.code` to `app.cs` using the command line (`mv` or `move`).
2.  Delete the entire `project` directory in one command (`rm -rf` or `rmdir /s /q`).

## Medium: The Toolsmith
1.  Install the `.NET 8 SDK`.
2.  Run `dotnet --version` to prove it works.
3.  Run `dotnet new console -o MyFirstApp`.
4.  Run it with `dotnet run`.

## Medium: The Editor
1.  Install VS Code.
2.  Install the "C# Dev Kit" extension.
3.  Open `MyFirstApp` using the command `code .` from the terminal.

## Medium: The Environment
1.  Create a temporary Environment Variable named `MY_SECRET` with value `Pizza`.
2.  Print it to the console (`echo $MY_SECRET` or `echo %MY_SECRET%`).

## Hard: The Scripter
1.  Write a simple shell script (`setup.sh` or `setup.bat`).
2.  It should: create a folder, create a file inside it, write "Hello World" into the file, and then print the file's contents.

## Hard: The Customized Cockpit
1.  Install a custom font (like Fira Code or JetBrains Mono).
2.  Configure your terminal to use it.
3.  Install a terminal theme (like Oh My Zsh or Oh My Posh).

## Boss Challenge: "The Ghost" 👻
**Goal:** Create a hidden folder structure that is hard to find.
1.  Create a folder named `.ghost` (the dot makes it hidden on Unix).
2.  Inside, create a file `secrets.txt` containing "I am here".
3.  Find a command that searches for the text "I am here" inside files in your current directory and reveals the location of the ghost. (Hint: `grep` or `findstr`).