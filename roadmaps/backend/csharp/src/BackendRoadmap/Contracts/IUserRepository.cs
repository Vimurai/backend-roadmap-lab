using System;
using System.Threading.Tasks;
using BackendRoadmap.Domain.Entities;

namespace BackendRoadmap.Contracts;

public interface IUserRepository
{
    Task<User?> GetByIdAsync(Guid id);
    Task SaveAsync(User user);
}
