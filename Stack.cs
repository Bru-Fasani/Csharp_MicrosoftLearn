Stack<int> Pilha = new Stack<int>();

Pilha.Push(2);
Pilha.Push(3);
Pilha.Push(4);
Pilha.Push(5);

foreach (var item in Pilha)
{
    Console.WriteLine(item.ToString());
}

//Remove o último item da Pilha
Pilha.Pop();

foreach (var item in Pilha)
{
    Console.WriteLine(item.ToString());
}
