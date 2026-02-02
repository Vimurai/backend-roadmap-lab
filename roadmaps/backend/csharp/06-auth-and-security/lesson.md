# 06 Auth and Security: The VIP Club

## 🧠 Analogy: The Passport
- **Authentication:** Proving you are who you say you are (The Passport).
- **Authorization:** Proving you have permission to enter a room (The VIP Wristband).
- **JWT (Token):** The digital wristband the server gives you after checking your passport.

## 🪝 Memory Hook
> *"AuthN is Who, AuthZ is What."*

## 📚 Core Concepts
- **Hashing:** Turning a password into a one-way scrambled mess (You can't unscramble it, you can only compare it).
- **Encryption:** Scrambling a message that can be unscrambled later with a key.
- **CORS:** The server deciding which "neighborhoods" (domains) are allowed to talk to it.

## 💡 If you forget, remember this:
**Never trust the client.** Even if the user is logged in, you must verify their permissions on *every single request*.

## 🗣️ Teach-Back Questions
- Why do we save a "hash" of a password instead of the password itself?
- What is the difference between "Login" and "Checking if the user is an Admin"?

## 📝 Checkpoint Quiz
1. What does JWT stand for?
2. What happens if a JWT is stolen?
3. What is a "Salt" in hashing?

## 🔄 Spaced Repetition
- **Previously:** How does HTTPS (Module 01) protect your login request?
- **Next Week:** You will store user data in a database in Module 07.