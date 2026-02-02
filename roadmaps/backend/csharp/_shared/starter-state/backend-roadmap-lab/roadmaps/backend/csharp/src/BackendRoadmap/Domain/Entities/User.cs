using System;
using BackendRoadmap.Domain.Enums;
using BackendRoadmap.Domain.ValueObjects;

namespace BackendRoadmap.Domain.Entities;

public class User
{
    public Guid Id { get; private set; }
    public Email Email { get; private set; }
    public UserRole Role { get; private set; }

    public User(Guid id, Email email, UserRole role)
    {
        Id = id;
        Email = email;
        Role = role;
    }

    // TODO: Add domain behaviors like UpdateEmail()
}
