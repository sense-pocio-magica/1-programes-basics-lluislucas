namespace exercici8;

/* Assigna un nombre total de minuts a una variable. 
Calcula quantes hores senceres i minuts restants són i imprimeix el resultat. */


/* int meitat = numero / 2;
int modul = numero % 2;
int modul = numero % 60; */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("quant minuts tardes fins la feina");
        string trajectefeina = Console.ReadLine();

        int minuts = Convert.ToInt32(trajectefeina);

        int enter = minuts / 60;
        int resta = minuts % 60;

        Console.WriteLine($"{trajectefeina} minuts són {enter} hores i {resta} minuts.");

    }
}
