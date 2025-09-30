namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("Nom del producte?");
        var producte = Console.ReadLine();

        Console.WriteLine("Quin es el preu?");
        var preu = Console.ReadLine();
        int num = Convert.ToInt32(preu);

        Console.WriteLine("Esta en estoc?");
        var estoc = Console.ReadLine();

        Console.WriteLine($"El producte {producte} val {preu} la seva disponibilitat es {estoc}");
    }
}
