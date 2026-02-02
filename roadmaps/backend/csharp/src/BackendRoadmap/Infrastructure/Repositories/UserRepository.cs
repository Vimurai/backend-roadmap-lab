using System;
using System.Threading.Tasks;
using BackendRoadmap.Contracts;
using BackendRoadmap.Domain.Entities;

namespace BackendRoadmap.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    public Task<User?> GetByIdAsync(Guid id)
    {
        // TODO: Implement EF Core or Dapper logic
        return Task.FromResult<User?>(null);
    }

    public Task SaveAsync(User user)
    {
        // TODO: Persist to DB
        return Task.CompletedTask;
    }
}
