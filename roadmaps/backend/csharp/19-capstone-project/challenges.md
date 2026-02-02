# ⚔️ Challenges: The Construction Phases

## Milestone 1: The Blueprint (Domain Layer)
**Goal:** Model the business rules without thinking about databases or APIs.
1.  Initialize a solution `CommunityHub.sln`.
2.  Create `CommunityHub.Domain` (Class Library).
3.  Implement Entities:
    - `Community` (Id, Name, Description, SubscriptionStatus).
    - `Member` (Id, Email, JoinDate).
4.  Implement Value Objects:
    - `Email` (Validates format).
    - `Money` (Amount, Currency).
5.  **Test:** Write Unit Tests for `Email` validation and `Money` addition logic.

## Milestone 2: The Foundation (Infrastructure Layer)
**Goal:** Set up the persistence mechanism.
1.  Create `CommunityHub.Infrastructure` and `CommunityHub.Application`.
2.  Define Interfaces in Application: `ICommunityRepository`, `IUnitOfWork`.
3.  Implement EF Core `DbContext` in Infrastructure.
4.  Configure `BaseEntity` configuration (Constraints, Keys) using `IEntityTypeConfiguration`.
5.  **Task:** Generate an Initial Migration and update a local database.

## Milestone 3: The Gates (Auth & API)
**Goal:** Let users in, but keep bad actors out.
1.  Create `CommunityHub.Api` (Web API).
2.  Implement `Register` and `Login` endpoints.
3.  Generate a **JWT** upon login containing `sub` (UserId) and `role` (Admin/Member).
4.  Add `[Authorize]` middleware to the API pipeline.

## Milestone 4: The Features (Vertical Slices)
**Goal:** Implement the core use cases (CQRS style recommended).
1.  **Create Community:** POST `/communities` (Only authenticated users).
2.  **Join Community:** POST `/communities/{id}/members`.
3.  **Create Event:** POST `/communities/{id}/events` (Only Community Admins).
4.  **List Events:** GET `/communities/{id}/events` (Cached for 60 seconds).

## Milestone 5: The Inspectors (Integration Testing)
**Goal:** Prove it works from the outside.
1.  Create `CommunityHub.Tests.Integration`.
2.  Use `WebApplicationFactory` to spin up an in-memory test server.
3.  **Scenario:** Register User -> Login (Get Token) -> Create Community -> Verify 201 Created.

## Milestone 6: The Assembly Line (CI/CD)
**Goal:** Automate the checks.
1.  Create a `.github/workflows/build.yml` file (see `docs/ci-pipeline.yml`).
2.  It should: Restore -> Build -> Test -> Publish Artifacts.

## Boss Challenge: "The Pivot" 💼
**New Requirement:** The CEO wants to support "Premium" communities that get a gold badge on their profile.
1.  Modify the Domain to handle `SubscriptionTier` (Free, Premium).
2.  Update the `Community` entity.
3.  Create a migration.
4.  Update the API response to include the badge status.
5.  **Constraint:** Do not break existing tests.