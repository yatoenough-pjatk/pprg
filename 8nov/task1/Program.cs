Console.WriteLine("Podaj liczbę:");

var userInput = Console.ReadLine()!;
var n = Int32.Parse(userInput);
var sum = 0;

for (int i = 1; i <= n; i++)
{
    sum += i;
}

Console.WriteLine($"Suma od 1 do {n}: {sum}");
