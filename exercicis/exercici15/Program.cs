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

            char lletranom = char.ToUpper(nom[0]);   // charinicial = char.ToUpper(nom[0]) char pq es nomes una lletra
            string restanom = nom.Substring(1);

            Console.WriteLine("Quin es el teu cognom?");
            string cognom = Console.ReadLine();

            char lletracognom = char.ToUpper(cognom[0]);
            string restacognom = cognom.Substring(1);

            Console.WriteLine("Em dic " + lletranom + restanom + " " + lletracognom + restacognom);
        }
    }

