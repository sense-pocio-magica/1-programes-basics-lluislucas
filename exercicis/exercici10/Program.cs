namespace exercici10;

/* Declara dues variables: una per al nom i una altra per l’any de naixement. 
Combina-les per crear una contrasenya bàsica (per exemple, Pere i 1982 -> Pere1982). 
Imprimeix la contrasenya generada (i sobretot no la facis servir mai que és molt dolenta) */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Com et dius?");
        string nom = Console.ReadLine();

        Console.WriteLine("Quin any has nascut?");
        string any = Console.ReadLine();

        int any_naixament = Convert.ToInt32(any);

        Console.WriteLine("PWD recomenat e indestructible " + nom + any_naixament + " 9 de cada 10 especialistas la recomiendan");
        Console.WriteLine("PWD recomenat e indestructible " + string.Concat(nom, any_naixament) + " 9 de cada 10 especialistas la recomiendan" );
    }
}
