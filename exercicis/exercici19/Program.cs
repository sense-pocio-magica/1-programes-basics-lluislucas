namespace exercici19;

// Assigna una paraula a una variable de text. Utilitza una funció per a obtenir la seva longitud i 
// imprimeix la paraula i el seu nombre de caràcters.
class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("Escriu una paraula");
            string paraula = Console.ReadLine();

            int longitud = paraula.Length;


            Console.WriteLine("La paraula és " + paraula + " i la seva longitud és de  " + longitud + " caracters");
    }
}
