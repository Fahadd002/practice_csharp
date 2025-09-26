using csharp_class;

Car myCar = new Car(180);
myCar.Start();
Console.WriteLine($"Engine started: {myCar.HasEngineStarted}");
Console.WriteLine($"Max speed: {myCar.MaxSpeed}");
myCar.Stop();
Console.WriteLine($"Engine started: {myCar.HasEngineStarted}");