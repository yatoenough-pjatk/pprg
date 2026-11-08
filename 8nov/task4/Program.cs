Console.WriteLine("Provide a number");

var n = int.Parse(Console.ReadLine()!);
var even = new List<int>();

for (var i = 2; i <= n; i += 2)
{
    even.Add(i);
}

Console.WriteLine($"Liczby parzyste: {string.Join(' ', even)}");
Console.WriteLine($"Liczb parzystych: {even.Count}");
Console.WriteLine($"Liczb nieparzystych: {n - even.Count}");
