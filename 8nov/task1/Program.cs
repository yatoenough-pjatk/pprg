Console.WriteLine("Provide a number");

var userInput = Console.ReadLine()!;
var n = Int32.Parse(userInput);
var sum = 0;

for (int i = 1; i <= n; i++)
{
    sum += i;
}

Console.WriteLine($"Sum: {sum}");
