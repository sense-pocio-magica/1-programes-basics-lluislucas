namespace exercici6;

/* Declara una variable per al costat d'un quadrat. Calcula el seu perímetre (suma dels quatre costats) 
i imprimeix-lo. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quan medeix el costat del quadrat");
        string mida = Console.ReadLine();

        int costat = Convert.ToInt32(mida);

        int perimetre = costat * 4;

        Console.WriteLine($"un costat medeix {mida} i el seu perimetre es de {perimetre}");
    }
}
