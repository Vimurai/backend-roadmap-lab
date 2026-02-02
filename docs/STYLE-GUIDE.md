# 🎨 Style Guide

## C# Code Style
- Follow standard Microsoft .NET naming conventions.
- PascalCase for classes and methods.
- camelCase for local variables and parameters.
- `_camelCase` for private fields.
- Use `var` when the type is obvious.

## Educational Comments
Comments should explain *Why*, not *What*.
```csharp
// BAD:
// Increment i
i++;

// GOOD:
// We move to the next pointer to process the rest of the list.
pointer++;
```

## Challenge Comments
Use `TODO` to mark areas for student intervention.
```csharp
// TODO: Implement the logic to validate the email format here.
// Hint: You might want to use a Regex or a built-in validator.
throw new NotImplementedException();
```
