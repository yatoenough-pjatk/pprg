Random rand = new();

int key = rand.Next(1, 101);
bool guessed = false;

while (!guessed)
{
    Console.Write("Zgadnij liczbę od 1 do 100: ");
    string? guessString = Console.ReadLine();

    bool isValidNumber = int.TryParse(guessString, out int playerGuess);

    bool numberInRange = playerGuess < 100 || playerGuess > 0;

    if (!isValidNumber || !numberInRange)
    {
        Console.WriteLine("Podaj poprawną liczbę od 1 do 100");
        continue;
    }

    if (playerGuess > key)
    {
        Console.WriteLine("Za duzo!");
    }
    else if (playerGuess < key)
    {
        Console.WriteLine("Za mało!");
    }
    else
    {
        guessed = true;
        Console.WriteLine("Brawo! Zgadłeś!");
    }
}
