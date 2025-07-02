Dictionary<string, string> Estados = new Dictionary<string, string>();

Estados.Add("SP", "São Paulo");
Estados.Add("RJ", "Rio De Janeiro");
Estados.Add("MG", "Minas Gerais");
Estados.Add("ES", "Espírito Santo");

Console.WriteLine("Estados Da Região Sudeste");

foreach (KeyValuePair<string, string> item in Estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
