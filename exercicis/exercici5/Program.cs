namespace exercici5;

/* Feu un programa que demani un nom i l’any de naixement i imprimeixi per pantalla 
“Hola [nom]!  Ja tens [edat] anys? 
nom i edat seran el nom introduït i l'edat la resta de l’any actual i l’any de naixement. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Com et dius?");
        string nom = Console.ReadLine();

        Console.WriteLine("Quin any vares neixer?");
        string any = Console.ReadLine();

        int any_naixament = Convert.ToInt32(any);

        int edat = 2025 - any_naixament;

        Console.WriteLine($"Hola {nom} ! Ja tens {edat} anys?");
    }
}
