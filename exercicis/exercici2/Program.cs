namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("A quin carrer vius?");
        var carrer = Console.ReadLine();

        Console.WriteLine("Quin numero de casa?");
        string numero = Console.ReadLine();

        Console.WriteLine("Quin es el codi postal?");
        string codi_postal = Console.ReadLine();

        Console.WriteLine("A quin poble o ciutat?");
        string ciutat = Console.ReadLine();


        Console.WriteLine($"Visc a {carrer} numero {numero} el codi postal es {codi_postal} de {ciutat}");
    }
}
