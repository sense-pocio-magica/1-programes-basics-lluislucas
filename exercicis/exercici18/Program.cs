namespace exercici18;

/* Un rellotger està perdent la memòria i necessita un programa que a partir de l'hora actual li puguem dir
 quina hora serà d’aquí un nombre determinat d’hores.

Hora actual: 9
Hores a incrementar: 3
D'aquí a 3 hores seran les 12


Hora actual: 11
Hores a incrementar: 3
D'aquí a 3 hores seran les 2
++(+1)
*/ 

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Quina hora es ara (1-12): ?");
        int ara = Convert.ToInt32(Console.ReadLine());

        Console.Write("Hores a incrementar: ");
        int incrementhora = Convert.ToInt32(Console.ReadLine());


        int novaHora = (ara + incrementhora) % 12;
        
        Console.WriteLine($"D'aquí a {incrementhora} hores seran les {novaHora}");
    }
}
