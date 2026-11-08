Console.WriteLine("Podaj imię: ");
string name = Console.ReadLine();

int gradeCount = 3;
int sum = 0;

for (int i = 0; i < gradeCount; i++)
{
    sum += ReadGrade();
}

decimal avg = (decimal)sum / gradeCount;

Console.WriteLine($"Imię: {name} Średnia: {avg:0.00}");

if (avg >= 3)
{
    Console.WriteLine("Zaliczone");
}
else
{
    Console.WriteLine("Nie zaliczone");
}

static int ReadGrade()
{
    Console.WriteLine("Podaj ocenę: ");
    string? gradeString = Console.ReadLine();

    int grade = ParseGrade(gradeString);

    return grade;
}

static int ParseGrade(string gradeString)
{
    bool parsedSuccessfully = int.TryParse(gradeString, out int grade);
    if (!parsedSuccessfully)
    {
        Console.WriteLine("To nie jest poprawna ocena (podaj ocenę od 1 do 6)");
        Environment.Exit(1);
    }

    if (grade < 1 || grade > 6)
    {
        Console.WriteLine("Musisz podać ocenę od 1 do 6");
        Environment.Exit(1);
    }

    return grade;
}
