# CommunityHub Architecture Guide

We follow **Clean Architecture** (also known as Onion or Hexagonal Architecture). This ensures the business logic is independent of external frameworks, UI, and databases.

## 🧱 The Layers

### 1. Domain (Core)
- **Dependencies**: None.
- **Contents**: Entities, Value Objects, Domain Exceptions, Domain Events, Enums.
- **Rule**: If it's a business rule, it lives here.

### 2. Application
- **Dependencies**: Domain.
- **Contents**: Use Cases (Commands/Queries), Service Interfaces, DTOs, Mapping logic.
- **Rule**: Orchestrates the flow of data to and from the domain.

### 3. Infrastructure
- **Dependencies**: Application.
- **Contents**: Database (EF Core), File System, Identity (JWT implementation), External API clients.
- **Rule**: Details about *how* we store/send data.

### 4. API (Presentation)
- **Dependencies**: Infrastructure, Application.
- **Contents**: Controllers/Endpoints, Middleware, Configuration (Program.cs).
- **Rule**: The entry point for the outside world.

## 🔄 Dependency Inversion
Inner layers define **Interfaces** (Contracts). Outer layers **Implement** them.
Example: `IUserRepository` is defined in `Application` but implemented in `Infrastructure`.
