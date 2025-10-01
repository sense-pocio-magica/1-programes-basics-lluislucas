namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Que has tret a catala?");
        string nota_catala = Console.ReadLine();

        int catala = Convert.ToInt32(nota_catala);

        Console.WriteLine("Que has tret a mates?");
        string nota_mates = Console.ReadLine();

        int mates = Convert.ToInt32(nota_mates);

        Console.WriteLine("Que has tret a fisica?");
        string nota_fisica= Console.ReadLine();

        int fisica = Convert.ToInt32(nota_fisica);

        int mitja = (catala + mates + fisica) / 3;

        Console.WriteLine($"la nota mitja es de {mitja}");
    }
}
