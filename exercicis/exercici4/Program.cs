namespace exercici4;

/* Un avi encara no sap quin és el valor de les coses perquè a tot arreu li parlen d’euros, 
però ell s’ha negat a canviar i encara té un pot ple de monedes de pesseta.
Necessita un programa amb el qual posi el valor de l'article que vol comprar en 
euros i li digui quin és el valor en les antigues pessetes
Nota: 1 euro = 166.386 pessetes i les pessetes no tenien cap decimal */

//fem servir float en vers de double perque el double ocupa més data i mostra més numeros, el float talla a 10-15 decimals

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quin és el preu en pessetes?");
        var preuproducte = Console.ReadLine();

        float preupessetes = Convert.ToInt32(preuproducte);

        float numero;
        float valoreuro = 166.386f;
        numero = preupessetes / valoreuro;

        Console.WriteLine($"El producte que val  {preuproducte} pessetes son {numero} en euros");

    }
}
