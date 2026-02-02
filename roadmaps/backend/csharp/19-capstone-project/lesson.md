# 19 Capstone: CommunityHub SaaS 🏙️

## 🧠 Mental Model: The General Contractor
You have spent 18 modules learning how to use hammers, drills, and saws.
Now, you are the **General Contractor**. You must build a skyscraper (a complete backend system) from the ground up.
You need to manage the **Foundation** (Database), the **Framework** (Domain Logic), the **Interiors** (API), and the **Security System** (Auth).

## 📋 Project Brief: "CommunityHub"
You are building the backend for a SaaS platform that helps local communities manage members and events.

### Core Domain
1.  **Communities:** A group (e.g., "Chess Club", "HOA").
2.  **Members:** Users who belong to communities with a Role (Admin, Member).
3.  **Events:** Gatherings with a date and location.
4.  **Subscriptions:** Communities pay a monthly fee (Value Object: Money).

## 🛠️ Tech Stack Requirements
*   **Language:** C# / .NET 8+
*   **Architecture:** Clean Architecture (Domain, App, Infra, API).
*   **Database:** PostgreSQL (or SQLite for local dev) + EF Core.
*   **Auth:** JWT (JSON Web Tokens).
*   **Testing:** xUnit + Moq (Unit) + WebApplicationFactory (Integration).
*   **Observability:** Serilog (Structured Logging).

## 🛑 The Rules
1.  **Domain First:** Do not start with the Database. Start with the Domain Entities.
2.  **No Primitives:** Use Value Objects (e.g., `Email`, `Money`, `Address`) instead of raw strings/ints.
3.  **Test the Core:** Your Domain and Application layers must have >80% unit test coverage.
4.  **Secure by Default:** No endpoint (except Login/Register) should be accessible without a valid Token.

## 🪝 Memory Hook
> *"Build the core, then plug in the ports."*