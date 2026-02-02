# 09 Caching: The Post-It Note

## 🧠 Analogy: The Librarian
You ask a librarian for a rare book. They walk to the basement (Database) to get it. It takes 10 minutes.
If the next person asks for the same book, the librarian pulls it from a shelf **behind the desk** (Cache). It takes 2 seconds.

## 🪝 Memory Hook
> *"Fast to Read, Hard to Keep Fresh."*

## 📚 Core Concepts
- **In-Memory Cache:** Storing data in the application's RAM (Super fast, but lost on restart).
- **Distributed Cache (Redis):** A separate server for caching (Shared by all your app instances).
- **TTL (Time To Live):** The expiration date on your Post-it note.

## 💡 If you forget, remember this:
The hardest part of caching is **Invalidation**. If the data in the basement changes, the book behind the desk is now "Stale" (wrong). You must decide when to throw it away.

## 🗣️ Teach-Back Questions
- Why don't we just cache everything?
- Explain the "Cache-Aside" pattern.

## 📝 Checkpoint Quiz
1. What is a "Cache Hit" vs. a "Cache Miss"?
2. What is Redis?
3. What happens if your cache size exceeds the available RAM?

## 🔄 Spaced Repetition
- **Previously:** How does a DB Index (Module 07) differ from a Cache?
- **Gating Check:** Revisit `_algorithms/02-hashmaps`.