# 13 Architecture Styles: The City Plan

## 🧠 Analogy: The Mall vs. The Main Street
- **Monolith (The Mall):** Everything is under one roof. Easy to manage, but if the power goes out, the whole mall closes.
- **Microservices (Main Street):** Every shop is a separate building. If the bakery closes, the bookstore stays open. But now you have to walk between buildings (Network latency).

## 🪝 Memory Hook
> *"Monolith for Speed, Microservices for Scale."*

## 📚 Core Concepts
- **Monolith:** One single deployable unit.
- **Microservices:** Multiple small, independent services communicating over the network.
- **Event-Driven:** Instead of calling someone, you shout "I finished!" (Events) and let others listen.

## 💡 If you forget, remember this:
**Don't start with Microservices.** They add massive complexity. Start with a "Modular Monolith" and only split when you have a massive team or specific scaling needs.

## 🗣️ Teach-Back Questions
- What are the downsides of having 50 small services instead of 1 big one?
- What is "Network Latency"?

## 📝 Checkpoint Quiz
1. What is a "Distributed System"?
2. What is the biggest challenge in Microservices? (Hint: Data consistency).
3. What is an API Gateway?

## 🔄 Spaced Repetition
- **Previously:** How does Clean Architecture (Module 12) help you transition to Microservices?
- **Next Week:** Learn how to package these services in Module 14.