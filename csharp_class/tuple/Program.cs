using tuple;

(string, int) person = ("Fahad", 26);
Console.WriteLine($"Name: {person.Item1}, Age: {person.Item2}");

(string Name, int Age) student = ("Aisha", 21);
Console.WriteLine($"Student Name: {student.Name}, Age: {student.Age}");


// Usage
int[] arr = { 5, 10, 3, 8 };
var result = Calculations.GetMinMax(arr);
Console.WriteLine($"Min: {result.Min}, Max: {result.Max}");

int[] numberCount = [1,3,4,5,4,5,8,9,2,3,4,7,5,0,9,2,4,1,6,8,2,4,3];
var counts = Calculations.GetNumberCount(numberCount);

foreach (var item in counts)
{
    Console.WriteLine($"Number: {item.Num}, Count: {item.Count}");
}
