namespace exercici9;

/* Demana un valor en metres. Converteix el valor a peus (1 metre = 3,28084 peus) 
i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("Quina es la mida en metres?");
        var midametres = Console.ReadLine();

        double  mida = Convert.ToInt32(midametres);

        double numero;
        double valorpeus = 3.28084;
        numero = mida * valorpeus;

        Console.WriteLine($"El valor de  {mida} m son {numero} en peus");
        
    }
}
