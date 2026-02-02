# 📅 1-Year Backend Master Plan (C#/.NET)

> **Commitment:** 2 Hours / Day (Monday - Friday).
> **Goal:** Zero to Junior/Mid-Level Backend Engineer.

This plan maps the `roadmaps/backend/csharp` curriculum to a 52-week schedule. It allows time for deep reading, debugging, and "stuck" moments.

---

## 🏗️ Phase 1: Foundations (Weeks 1-8)
**Goal:** Master the tools of the trade and the language syntax.

### Week 1: The Landscape & The Terminal
*   **Topics:** How the Internet works (DNS, HTTP, IP), Terminal basics, VS Code setup.
*   **Outcomes:** Can explain what happens when you type `google.com`. Comfortable with CLI.
*   **Deliverables:** `00-orientation`, `01-internet-foundations`
*   **Checkpoint Quiz:** What is the difference between an IP address and a Domain Name?
*   **Mini Project:** Use `curl` to manually send GET and POST requests to `httpbin.org`.

### Week 2: Git & Version Control
*   **Topics:** Git flow, commits, branching, merging, pull requests.
*   **Outcomes:** Can safely save work and collaborate without fear of losing code.
*   **Deliverables:** `02-git-and-hosting`
*   **Checkpoint Quiz:** Why do we use branches instead of committing directly to `main`?
*   **Mini Project:** Create a repo, make a "bug", fix it on a branch, and merge it back.

### Weeks 3-5: C# Language Core
*   **Topics:** Variables, Types, Control Flow, Classes, Interfaces, Exception Handling.
*   **Outcomes:** Can write idiomatic C# logic. Understands OOP principles (Encapsulation, Polymorphism).
*   **Deliverables:** `03-csharp-language-core` (Spend 3 weeks here! It's heavy.)
*   **Checkpoint Quiz:** What is the difference between a `class` (Reference Type) and a `struct` (Value Type)?
*   **Mini Project:** Build a text-based "ATM" console app that handles deposits, withdrawals, and insufficient funds exceptions.

### Weeks 6-7: .NET Tooling & Ecosystem
*   **Topics:** The CLR, NuGet, `dotnet` CLI, Debugging, Solution structure.
*   **Outcomes:** Can create, build, and debug projects from the command line.
*   **Deliverables:** `04-dotnet-and-tooling`
*   **Checkpoint Quiz:** What is the role of the `.csproj` file?
*   **Mini Project:** Create a solution with two projects: a Console App and a Class Library. Reference the library from the app.

### Week 8: Buffer Week
*   **Task:** Review Weeks 1-7. Re-do the "ATM" project from scratch without looking at the old code.

---

## 🔌 Phase 2: Backend Essentials (Weeks 9-16)
**Goal:** Build APIs that the world can talk to.

### Weeks 9-11: APIs, HTTP & REST
*   **Topics:** REST constraints, Status Codes, Controllers vs. Minimal APIs, Middleware, Dependency Injection (DI).
*   **Outcomes:** Can build a functional API with Create, Read, Update, Delete (CRUD) operations.
*   **Deliverables:** `05-apis-http-rest`
*   **Checkpoint Quiz:** When should you use `400 Bad Request` vs `500 Internal Server Error`?
*   **Mini Project:** Build a "Todo API" where todos are stored in a static List in memory.

### Weeks 12-14: Auth & Security
*   **Topics:** Authentication vs. Authorization, JWTs, Hashing, Salting, CORS.
*   **Outcomes:** Can secure an API so only logged-in users can access it.
*   **Deliverables:** `06-auth-and-security`
*   **Checkpoint Quiz:** Why must we never save plain-text passwords in a database?
*   **Mini Project:** Add a Login endpoint to your Todo API that issues a fake JWT.

### Week 15: Review & Consolidation
*   **Topics:** Refactoring, Code style reviews.
*   **Deliverables:** Review previous code.
*   **Task:** Take your "Todo API" and separate the Controller logic from the Data logic (Service Layer).

### Week 16: Buffer Week
*   **Task:** Catch up on any unfinished modules.

---

## 💾 Phase 3: Data Persistence (Weeks 17-24)
**Goal:** Make data survive a server restart.

### Weeks 17-19: Relational Databases & SQL
*   **Topics:** Tables, Keys (Primary/Foreign), Normalization, Indexes, SQL Queries.
*   **Outcomes:** Can design a normalized schema and write SQL `JOIN`s.
*   **Deliverables:** `07-relational-databases`
*   **Checkpoint Quiz:** What is a Foreign Key constraint?
*   **Mini Project:** Design a DB schema for a "Library System" (Books, Authors, Loans) on paper/diagram.

### Weeks 20-22: EF Core (ORM)
*   **Topics:** Code-First Migrations, DbContext, LINQ, Change Tracking, Relationships in C#.
*   **Outcomes:** Can interact with a database using only C# code.
*   **Deliverables:** `08-orm-ef-core`
*   **Checkpoint Quiz:** What is the "N+1 Problem" in ORMs?
*   **Mini Project:** Connect your "Todo API" to a real PostgreSQL or SQLite database using EF Core.

### Week 23: Caching
*   **Topics:** In-Memory Cache, Distributed Cache (Redis), Cache Invalidation.
*   **Outcomes:** Can make slow endpoints fast.
*   **Deliverables:** `09-caching`
*   **Checkpoint Quiz:** Why is "Stale Data" a risk when caching?
*   **Mini Project:** Cache the "Get All Todos" endpoint for 60 seconds.

### Week 24: Buffer Week
*   **Task:** Deep dive into LINQ. Practice complex queries (Group By, SelectMany).

---

## 🛡️ Phase 4: Quality & DevOps (Weeks 25-32)
**Goal:** Professionalize your workflow.

### Weeks 25-27: Testing
*   **Topics:** Unit vs. Integration Tests, xUnit, Moq, Test-Driven Development (TDD).
*   **Outcomes:** Can write code that verifies itself.
*   **Deliverables:** `10-testing`
*   **Checkpoint Quiz:** What is "Mocking" and why do we do it?
*   **Mini Project:** Achieve 80% code coverage on your Todo API logic.

### Weeks 28-29: CI/CD
*   **Topics:** GitHub Actions, Build Pipelines, Automated Testing, Docker Basics.
*   **Outcomes:** Code is automatically built and tested on every push.
*   **Deliverables:** `11-ci-cd`
*   **Checkpoint Quiz:** What happens if the CI build fails?
*   **Mini Project:** Create a GitHub Action workflow that runs `dotnet test` on every commit.

### Week 30: Observability
*   **Topics:** Structured Logging (Serilog), Metrics (OpenTelemetry), Tracing.
*   **Outcomes:** Can diagnose *why* an error happened in production.
*   **Deliverables:** `18-observability` (Moved up to help with debugging).
*   **Checkpoint Quiz:** What is a "Correlation ID"?
*   **Mini Project:** Configure your API to log all requests to the console as JSON.

### Weeks 31-32: Buffer & Refactor
*   **Task:** Apply everything (Tests, CI, Logs) to your Library System or Todo App.

---

## 🏗️ Phase 5: Architecture & Scale (Weeks 33-44)
**Goal:** Build systems that grow.

### Weeks 33-35: Design Patterns & Clean Architecture
*   **Topics:** SOLID Principles, Dependency Injection patterns, Clean/Onion Architecture, DDD Lite.
*   **Outcomes:** Can structure complex applications clearly.
*   **Deliverables:** `12-design-patterns-ddd-lite-clean-architecture`
*   **Checkpoint Quiz:** What does the "D" in SOLID stand for?
*   **Mini Project:** Refactor your API into strict layers: `Core`, `Infrastructure`, `API`.

### Weeks 36-37: Architecture Styles & Containers
*   **Topics:** Monoliths, Microservices, Docker Compose, Container Orchestration concepts.
*   **Outcomes:** Can containerize applications.
*   **Deliverables:** `13-architecture-styles`, `14-containers-and-web-servers`
*   **Checkpoint Quiz:** Why is a Monolith often better than Microservices for starting?
*   **Mini Project:** Run your API and a DB in Docker Compose.

### Weeks 38-39: Async Messaging
*   **Topics:** Message Queues (RabbitMQ), Pub/Sub, Eventual Consistency.
*   **Outcomes:** Can decouple services.
*   **Deliverables:** `15-message-brokers`
*   **Checkpoint Quiz:** What is a "Dead Letter Queue"?
*   **Mini Project:** Create a background worker that processes "Email Notifications" (simulated) from a queue.

### Weeks 40-41: NoSQL & specialized storage
*   **Topics:** Document DBs (Mongo/Cosmos), Key-Value.
*   **Outcomes:** Knows when *not* to use SQL.
*   **Deliverables:** `16-nosql`
*   **Checkpoint Quiz:** What is "Schemaless" data?
*   **Mini Project:** Store "User Session Logs" in a NoSQL store.

### Weeks 42-43: Scaling & Resilience
*   **Topics:** Load Balancing, Circuit Breakers (Polly), Rate Limiting.
*   **Outcomes:** System stays up when under load or when dependencies fail.
*   **Deliverables:** `17-scaling-and-resilience`
*   **Checkpoint Quiz:** How does a Circuit Breaker prevent cascading failures?
*   **Mini Project:** Implement a Retry policy on your database calls.

### Week 44: Buffer Week
*   **Task:** Rest. Prepare for the Capstone.

---

## 🎓 Phase 6: The Capstone (Weeks 45-52)
**Goal:** Build a complete, production-ready system.

### Weeks 45-46: Planning & Design
*   **Deliverables:** `19-capstone-project`
*   **Task:** Define requirements, Draw Architecture Diagrams, Plan API endpoints.
*   **Project Idea:** "Ticketmaster Clone" (High concurrency, complex data, payments).

### Weeks 47-50: Implementation
*   **Weeks 47-48:** Core Domain & Logic (Tests First!).
*   **Week 49:** API & Database Integration.
*   **Week 50:** Infrastructure (Docker, Auth, Logs).

### Week 51: Polish & Docs
*   **Task:** Write a great README. Add Swagger documentation. Fix edge-case bugs.

### Week 52: Release & Celebration
*   **Task:** "Deploy" it (even if just to a local Docker setup). Record a demo video. Update your CV.