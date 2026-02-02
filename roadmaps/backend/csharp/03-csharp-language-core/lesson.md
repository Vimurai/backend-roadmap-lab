# 03 C# Language Core: The Factory Floor

## 💡 The Analogy: Blueprints & Boxes
Imagine a **Factory**.
- **Classes** are the **Blueprints**: They tell you how to build a robot, but they aren't the robot itself.
- **Objects** are the **Robots**: The actual things built from the blueprint.
- **Variables** are **Labeled Boxes**: You can put a robot in a box labeled "Worker", but you can't put a sandwich in there (Strong Typing).
- **Methods** are the **Buttons** on the robot: Press one, and it does something.

## 📚 Core Concepts

### 1. Strong Typing
C# is strict. If you say a box holds `int` (integers), you can't put a `string` (text) in it.
```csharp
int age = 25;
// age = "twenty-five"; // ❌ ERROR: The compiler protects you.
```

### 2. Control Flow (Logic)
The logic is the conveyor belt.
- `if/else`: Switch tracks.
- `for/foreach`: Repeat a task for every item in a box.

### 3. Classes & Methods
```csharp
public class Robot // Blueprint
{
    public string Name { get; set; } // Property (State)

    public void SayHello() // Method (Behavior)
    {
        Console.WriteLine($"Beep boop. I am {Name}.");
    }
}
```

## 🎯 Lab Objectives
You will build a **Coffee Machine** software controller.
1.  Define the `CoffeeMachine` class.
2.  Manage resources (Water, Beans).
3.  Throw exceptions if resources are low (Safety checks).
## 🛑 Gating Checklist
Before moving to the next module, complete:
- [ ] `_algorithms/00-big-o` (Understanding Performance)
- [ ] `_algorithms/01-arrays-strings` (Basic Manipulation)
