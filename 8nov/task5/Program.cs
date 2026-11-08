Console.WriteLine("Provide a number");

var n = int.Parse(Console.ReadLine()!);

for (int i = 0; i < n; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
