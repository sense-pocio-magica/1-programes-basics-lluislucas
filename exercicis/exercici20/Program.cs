namespace exercici20;

/* Ens cal un programa que quan li entrem un número de tres xifres i ens retorni 
el número amb els dígits invertits. 

Ex. 245 -> 542
Entra el número a invertir: 347
El número invertit és: 743
*/

/*seprem el numero en centenes,desenes i unitats si el nunmero es 732
fem modul 10  em dvidira 730 i donara residu 2


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

Tractant el numero com a sttring

string num = " 345"
string centenes = num[0];---3
string desenes = num [1];---4
string unitats = [2];---5

CWL ( unitats + desenes + centenes);

Tractant el numero com a numero

345 % 10 = 5

int unitats = 345 
int unitats = 345 % 10 = 5
int centenes = 345 / 100 = 3
int desenes = ( 345 % 100) = 3
