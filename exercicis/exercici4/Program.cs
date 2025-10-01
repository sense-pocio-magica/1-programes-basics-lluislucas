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
        var producte = Console.ReadLine();
        int trans = Convert.ToInt32(producte);

        Console.WriteLine("Quin es el preu?");
        var preu = Console.ReadLine();
        int num = Convert.ToInt32(preu);


        Console.WriteLine($"El producte {producte} val {preu} la seva disponibilitat es {estoc}");
        
    }
}
