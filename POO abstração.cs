class Carro
{
   public string Marca;
   public string Modelo;
   public int Ano;

   public void MostratInfos()
   {

    Console.WriteLine($"Carro: {Marca} \n Modelo:{Modelo},{Ano}");
   }

}

class Program
{
    static void Main()
    {
        Carro meuCarro = new Carro();
        meuCarro.Marca = "BMW";
        meuCarro.Modelo = "M4";
        meuCarro.Ano = 2024;

        meuCarro.MostratInfos();
    }
}
