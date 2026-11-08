static int GetNumberFromUser()
{
    var userInput = Console.ReadLine()!;
    var n = Int32.Parse(userInput);

    return n;
}

Console.WriteLine("Ile ocen? ");
var n = GetNumberFromUser();
var grades = new List<int>();

for (int i = 0; i < n; i++)
{
    Console.Write("Podaj ocene: ");
    var grade = GetNumberFromUser();
    grades.Add(grade);
    Console.WriteLine();
}

var max = grades.Max();
var min = grades.Min();
double avg = grades.Average();
var positiveCount = grades.Count(g => g >= 3);

Console.WriteLine($"Max: {max}");
Console.WriteLine($"Minimalna: {min}");
Console.WriteLine($"Srednia: {avg:F2}");
Console.WriteLine($"Pozytywnych: {positiveCount}");
