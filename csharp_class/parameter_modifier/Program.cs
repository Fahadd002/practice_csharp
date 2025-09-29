using parameter_modifier;

Calculations calc = new Calculations();

// 1. Using params
int total = calc.Sum(1, 2, 3, 4);
Console.WriteLine($"Sum: {total}");

// 2. Using in
int original = 5;
int squared = calc.Square(in original);
Console.WriteLine($"Square of {original}: {squared}");

// 3. Using out
int output;
calc.GetDouble(10, out output);
Console.WriteLine($"Double of 10: {output}");

// 4. Using ref
int value = 7;
calc.Increment(ref value);
Console.WriteLine($"Incremented value: {value}");