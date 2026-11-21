static bool IsPrime(long n)
{
    if (n < 2)
        return false;
    if (n < 4)
        return true;
    if (n % 2 == 0 || n % 3 == 0)
        return false;

    for (long i = 5; i * i <= n; i += 6)
    {
        if (n % i == 0 || n % (i + 2) == 0)
        {
            return false;
        }
    }

    return true;
}

Console.WriteLine("Podaj liczbę");

var n = int.Parse(Console.ReadLine()!);

Console.WriteLine(IsPrime(n) ? $"{n} jest pierwszą" : $"{n} nie jest pierwszą");
