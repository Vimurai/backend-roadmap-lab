# 14 Containers & Web Servers: The Shipping Container

## 🧠 Analogy: The Literal Shipping Container
Before 1950, shipping was slow because every box was a different size.
Then came the **Standard Container**.
**Docker** is that container for code. It doesn't matter if your app is C#, Python, or Go; it fits in the container and runs on any ship (Server).

## 🪝 Memory Hook
> *"It works on my machine... because my machine is a container."*

## 📚 Core Concepts
- **Image:** The "Blueprint" or "Snapshot" of your app and its tools.
- **Container:** The running instance of that image.
- **Reverse Proxy (Nginx/Kestrel):** The security guard at the front door who directs traffic to the right room.

## 💡 If you forget, remember this:
A container is **not** a Virtual Machine. It shares the computer's brain (OS Kernel), making it much faster and lighter.

## 🗣️ Teach-Back Questions
- Why is Docker better than just installing .NET on every server?
- What is a "Dockerfile"?

## 📝 Checkpoint Quiz
1. What command starts a container?
2. What is the difference between an Image and a Container?
3. What is Docker Compose?

## 🔄 Spaced Repetition
- **Previously:** How does the .NET Runtime (Module 04) interact with a container?
- **Gating Check:** Complete `_algorithms/06-graphs` to understand dependency mapping.