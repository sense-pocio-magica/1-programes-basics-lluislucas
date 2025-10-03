namespace exercici14;

// Declara una paraula i fes que el programa imprimeixi només la primera lletra, l'última lletra i la lletra del mig 
/* 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, ");
    }
}*/
class Program
{
    static void Main(string[] args);



    Console.WriteLine("digues una paraula");
    
    string paraula = Console.ReadLine();

    primeralletra = paraula.Length[0]
    mitjalletra = paraula.Length / 2

        ultimalletra = paraula.Length-1

        Console.WriteLine($ "Les lletres son {primeralletra} + {mitjalletra} + {ultimalletra} ");
}
