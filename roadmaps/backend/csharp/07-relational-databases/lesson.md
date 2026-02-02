# 07 Relational Databases: The Giant Spreadsheet

## 🧠 Analogy: The Filing Cabinet
- **Tables:** The drawers labeled "Users", "Orders", "Products".
- **Rows:** The individual folders inside a drawer.
- **Columns:** The specific fields in each folder (Name, Date, Price).
- **Foreign Key:** A note in an "Order" folder that says "See User Folder #402" (The Relationship).

## 🪝 Memory Hook
> *"Keep your data normalized, keep your life simple."*

## 📚 Core Concepts
- **Normalization:** Organizing data to reduce redundancy (Don't store the user's address in 50 order rows).
- **Indexes:** The "Table of Contents" at the start of a book that helps you find a page instantly.
- **ACID:** The guarantee that your database transaction either works completely or not at all (No half-baked data).

## 💡 If you forget, remember this:
A relational database is all about **integrity**. It ensures that if you delete a "User", you don't leave "Ghost Orders" floating around that belong to nobody.

## 🗣️ Teach-Back Questions
- Why do we split data into multiple tables instead of one big table?
- What is the difference between a Primary Key and a Foreign Key?

## 📝 Checkpoint Quiz
1. What does SQL stand for?
2. What happens to a query if there is no Index on the searched column?
3. Name the four properties of ACID.

## 🔄 Spaced Repetition
- **Previously:** How do we secure the data being sent to the DB? (Check Module 06).
- **Gating Check:** Complete `_algorithms/05-trees` to understand how Indexes work.