namespace exercici15;

// Assigna un nom i un cognom en variables. Imprimeix el nom complet, 
// assegurant-te que la primera lletra de cada paraula estigui en majúscula
//nom.ToUpper()
class Program
{
    static void Main(string[] args)
    {
        
            Console.WriteLine("Com et dius?");
            string nom = Console.ReadLine();

            string primeralletra = nom[0].ToString().ToUpper();
            string restanom = nom.Substring(1);

            Console.WriteLine("Quin es el teu cognom?");
            string cognom = Console.ReadLine();

            string primeralletra2 = cognom[0].ToString().ToUpper();
            string restacognom = cognom.Substring(1);

            Console.WriteLine("Em dic " + primeralletra + restanom + " " + primeralletra2 + restacognom);
        }
    }

