Console.WriteLine("Generating random numbers:");
DisplayRandomNumbers();

void DisplayRandomNumbers()
{
    var randomNumbers = new Random();

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"{randomNumbers.Next(0, 100)}");
    }
    Console.WriteLine();
}
