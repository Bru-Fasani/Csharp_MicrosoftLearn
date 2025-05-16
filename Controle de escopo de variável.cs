int[] numbers = { 4, 8, 15, 16, 23, 42 };
bool found = true;
int total = 0;


/* minha tentativa
foreach (int number in numbers)
{
    total += number;

    if (number == 42)
    {
       Console.WriteLine("Set contains 42");

    }

    else
    {
        Console.WriteLine($"Total: {total}");
    }
}*/

// possível solução
foreach (int number in numbers)
{
    total += number;
    if(number == 42)
       found = true;
}

 if(found)
 Console.WriteLine("Set contains 42");

 Console.WriteLine($"total: {total}");
