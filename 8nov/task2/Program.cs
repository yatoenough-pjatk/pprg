Console.WriteLine("Provide a number");

var userInput = Console.ReadLine()!;
var n = Int32.Parse(userInput);

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{n} * {i} = {n * i}");
}
