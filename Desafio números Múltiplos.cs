using System; 

class minhaClasse {

    static void Main(string[] args) { 

        int suavariavel = int.Parse(Console.ReadLine());
        string[] n = Console.ReadLine().Split(' ');

        int multiplo2 = 0;
        int multiplo3 = 0;
        int multiplo4 = 0;
        int multiplo5 = 0;

        for (int iContador = 0; iContador < suavariavel; iContador++)
        {
            int numero = int.Parse(n[iContador]);
            if (numero % 2 == 0) multiplo2++;
            if (numero % 3 == 0) multiplo3++;
            if (numero % 4 == 0) multiplo4++;
            if (numero % 5 == 0) multiplo5++;
        }

        Console.WriteLine("{0} Multiplo(s) de 2", multiplo2);
        Console.WriteLine("{0} Multiplo(s) de 3", multiplo3);
        Console.WriteLine("{0} Multiplo(s) de 4", multiplo4);
        Console.WriteLine("{0} Multiplo(s) de 5", multiplo5);
    }
}
