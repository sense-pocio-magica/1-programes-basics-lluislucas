namespace exercici4;

/* Un avi encara no sap quin és el valor de les coses perquè a tot arreu li parlen d’euros, 
però ell s’ha negat a canviar i encara té un pot ple de monedes de pesseta.
Necessita un programa amb el qual posi el valor de l'article que vol comprar en 
euros i li digui quin és el valor en les antigues pessetes
Nota: 1 euro = 166.386 pessetes i les pessetes no tenien cap decimal */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quin és el preu en pessetes?");
        var preuproducte = Console.ReadLine();

        double  preupessetes = Convert.ToInt32(preuproducte);

        double numero;
        double valoreuro = 166.386;
        numero = preupessetes / valoreuro;

        Console.WriteLine($"El producte que val  {preuproducte} pessetes son {numero} en euros");
        
    }
}
