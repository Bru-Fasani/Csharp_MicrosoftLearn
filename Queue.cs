Queue<int> Fila = new Queue<int>();

Fila.Enqueue(12);
Fila.Enqueue(25);
Fila.Enqueue(33);
Fila.Enqueue(47);

foreach (var item in Fila)
{
    Console.WriteLine(item);
}

//remove o primeiro elemento da fila toda vez que o código é executado
Fila.Dequeue();
Console.WriteLine($"Removeu o primeiro elemento");

foreach (var item in Fila)
{
    Console.WriteLine(item);
}
