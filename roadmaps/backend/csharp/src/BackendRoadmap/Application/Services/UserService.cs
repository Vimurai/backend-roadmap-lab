using System;
using System.Threading.Tasks;
using BackendRoadmap.Contracts;
using BackendRoadmap.Domain.Entities;
using BackendRoadmap.Domain.Enums;
using BackendRoadmap.Domain.ValueObjects;

namespace BackendRoadmap.Application.Services;

public class UserService
{
    private readonly IUserRepository _repository;

    public UserService(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task RegisterUserAsync(string emailAddress)
    {
        var email = Email.Create(emailAddress);
        var user = new User(Guid.NewGuid(), email, UserRole.User);
        
        await _repository.SaveAsync(user);
        
        // TODO: Publish "UserRegistered" event
    }
}
