namespace exercici17;

/* Hi ha una secta d’adoradors dels decimals que volen que els hi feu un programa que a partir d’un nombre real, 
ex. 4.56, només ens retorni els decimals, 0,56. Als números que només tenen decimals els anomenen “nombres meravellosos”

Número lleig: 23,45
Nombre meravellós: 0,45


Número lleig: 8,5
Nombre meravellós: 0,5
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introdueix un numero:");
        string numero = Console.ReadLine();

        Console.WriteLine("quants decimals te el numero");
        int posicionsacomptar = Convert.ToInt32(Console.ReadLine());

        string decimals = numero.Substring(numero.Length - posicionsacomptar);

        Console.WriteLine("Número lleig: " + numero);
        Console.WriteLine("Numero marevallos:  0 ," + decimals);
    }
}
// no se m'acut res mes per saber els decimals