using System;

namespace BackendRoadmap.Domain.ValueObjects;

public record Email(string Value)
{
    public static Email Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Email cannot be empty");
        // TODO: Add Regex validation
        return new Email(value);
    }
}
