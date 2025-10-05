namespace exercici12;

/* Fes un programa que a partir de dos números imprimeixi per pantalla la seva suma, la seva resta, 
la seva multiplicació i la seva divisió

Entra el primer número: 3
Entra el segon número: 4

4 + 3 = 7
4 - 3 = 1
4 * 5 = 12
4 / 3 = 1  i en sobra 1


Entra el primer número: 25
Entra el segon número: 5

25 + 5 = 30
25 - 5 = 20
25 * 5 = 125
25 / 5 = 5  i en sobra 0
*/



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("digues un numero?");
        var numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digues un altre numero");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        int suma= numero1+numero2;
        int resta= numero1-numero2;
        int multiplicacio= numero1*numero2;
        int divisio= numero1/numero2;
        int decimals = divisio % 1;         // pq si dividim per 1 sempre dona els decimals despres de treure la part entera et deixa el ameteix numero i obtens el decimal




        Console.WriteLine($"els resulatsts son {suma} , {resta} , {multiplicacio} , {divisio}  i en sobra {decimals}");

    } 
}
