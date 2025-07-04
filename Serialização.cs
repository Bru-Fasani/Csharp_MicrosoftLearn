using Newtonsoft.Json;
using teste.Models;

DateTime DataAtual = DateTime.Now;

Venda v1 = new Venda(1, "Produto teste", 123M, DataAtual);
Venda v2 = new Venda(2, "Produto de teste 2", 2M, DataAtual);

List<Venda> ListaVendas = new List<Venda>();

ListaVendas.Add(v1);
ListaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(ListaVendas) ;

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine ( serializado );
