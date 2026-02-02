# 12 Design Patterns & Clean Architecture: The Architect's Blueprints

## 🧠 Analogy: The Remodeler's Nightmare
- **Spaghetti Code:** The wires, plumbing, and structure are all tangled together. To fix a light, you have to break the toilet.
- **Clean Architecture:** The walls (UI), the plumbing (DB), and the living space (Business Logic) are separated. You can replace the sink without tearing down the house.

## 🪝 Memory Hook
> *"Dependency should only point inward."*

## 📚 Core Concepts
- **SOLID:** Five principles for writing flexible, maintainable code.
- **Dependency Injection:** Don't "buy" your tools inside the job; ask for them in the constructor (The Waiter brings the food).
- **Separation of Concerns:** Keep your "Database logic" away from your "Tax calculation logic".

## 💡 If you forget, remember this:
**Clean Architecture** is about protecting your **Business Logic**. The database and the web framework are just "details" that should be easy to swap out.

## 🗣️ Teach-Back Questions
- Why do we want our business logic to know nothing about SQL?
- Explain the "Single Responsibility Principle".

## 📝 Checkpoint Quiz
1. What does the "D" in SOLID stand for?
2. What is an "Entity" vs a "Value Object"?
3. In Clean Architecture, which layer is at the very center?

## 🔄 Spaced Repetition
- **Previously:** How does the `Lab.csproj` solution we built follow these rules?
- **Next Week:** See how this architecture scales in Module 13.