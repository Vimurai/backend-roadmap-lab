# 08 ORM & EF Core: The Universal Translator

## 🧠 Analogy: The Interpreter
You speak **C# Objects**. The database speaks **SQL**.
**Entity Framework (EF Core)** is the **Interpreter** sitting between you. You say "Give me the list of Users", and it translates it into `SELECT * FROM Users`.

## 🪝 Memory Hook
> *"Code-First for Control, Database-First for Legacy."*

## 📚 Core Concepts
- **DbContext:** The "Session" or "Connection" to the translator.
- **Migrations:** The "Version Control" for your database schema.
- **LINQ:** Writing queries in C# that look like logic but turn into SQL.

## 💡 If you forget, remember this:
EF Core is powerful but can be **lazy**. If you aren't careful, it might make 100 trips to the database (N+1 Problem) when it only needed one. Always check your logs!

## 🗣️ Teach-Back Questions
- Why would we use an ORM instead of just writing raw SQL?
- What is a Migration and why is it better than manually editing tables?

## 📝 Checkpoint Quiz
1. What command do you use to create a new migration?
2. What is "Eager Loading"?
3. True or False: You should always use `ToList()` at the end of a LINQ query immediately.

## 🔄 Spaced Repetition
- **Previously:** Refresh your knowledge of Tables and Foreign Keys (Module 07).
- **Next Week:** Learn how to speed up these queries with Caching in Module 09.