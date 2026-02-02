# CommunityHub API Specification

## 🔓 Public Endpoints
These endpoints do not require an Authorization header.

### Identity
- `POST /api/identity/register`: Create a new user account.
- `POST /api/identity/login`: Exchange credentials for a JWT.

---

## 🔒 Protected Endpoints
Require `Authorization: Bearer <token>`

### Communities
- `POST /api/communities`: Create a new community.
- `GET /api/communities`: List all communities (Paginated).
- `GET /api/communities/{id}`: Get details for a specific community.

### Memberships
- `POST /api/communities/{id}/join`: Join a community as a member.
- `GET /api/communities/{id}/members`: List members of a community.

### Events
- `POST /api/communities/{id}/events`: Create a new event (Admin only).
- `GET /api/communities/{id}/events`: List upcoming events for a community.

---

## 🛠️ Implementation Notes
- **Content-Type**: `application/json`
- **Error Format**:
  ```json
  {
    "error": "Short description",
    "details": ["Specific validation error 1", "Specific validation error 2"]
  }
  ```
- **Pagination**: Use query params `page` and `pageSize`.
