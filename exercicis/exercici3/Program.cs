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
        double num = Convert.ToDouble(preu);

        Console.WriteLine("Esta en estoc?");
        int stock = 7; //aixo son les unitats
        bool hihastock = stock > 0;

        if (hihastock)

            Console.WriteLine("✅ Tenim " + stock + "unitats");


        else
        {
            Console.WriteLine("❌ No hi ha stock.");
        }

        Console.WriteLine($"El producte {producte} val {preu} la seva disponibilitat es {hihastock} + unitats");
    }
}
