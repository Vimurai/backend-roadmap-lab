# ⚔️ Challenges: The Coffee Machine

## Goal
Implement a `CoffeeMachine` class that manages water and beans to produce coffee.

## Task 1: The Blueprint
Open `src/Exercise.cs`.
You will see a class `CoffeeMachine`.
1.  Add properties for `WaterLevel` and `BeanLevel` (Integers).
2.  Initialize them to 0 in the constructor.

## Task 2: Re-stocking
Implement the `Fill(int water, int beans)` method.
- It should add to the current levels.
- **Analogy:** Pouring ingredients into the top of the machine.

## Task 3: Brewing (The Logic)
Implement the `MakeCoffee()` method.
- **Requirement:** A coffee costs 50 units of water and 10 units of beans.
- **Check:** If `WaterLevel < 50`, throw an `InvalidOperationException` with message "Not enough water".
- **Check:** If `BeanLevel < 10`, throw an `InvalidOperationException` with message "Not enough beans".
- **Action:** Subtract the used ingredients.
- **Return:** Return true if successful.

## Task 4: Verification
Run `dotnet test` to verify your machine works as expected.