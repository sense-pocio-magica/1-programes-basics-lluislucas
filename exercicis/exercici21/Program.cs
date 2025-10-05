namespace exercici21;

/* Perquè tens escrit a un perfil públic "Em penso que deixo de lluitar contra la superficialitat humana"? 
M'ha fet pensar... perque algu pensa aixi i ho escriu a un lloc on ho pot veure tothom?
es un descuit, vol provocar a algú, una proba?

Ningu pot ser 0% superficial forma part de la naturalesa humana, com l enveja ,l avaricia, la humilitat o la generositat.
No importa tenir un punt de superficial, no pots  matarte a intentar ser 0% doncs tb pot portar a situacions de perill.
Algu 0 sup seria inocencia pura i dura i el mon es una selva en guerra que no perdona a ningu.

Potser nomes els animals no son superficials, mira els gossos que estan amb mendigos

És mes questio de percentatges, hi ha un moment que has de decidir quins seran els valors amb els que et guies a la vida.
La forsa d un ser s identifica per la voluntat de guiarse segons els seus valors independentment de la situacio 
Si no vols ser superficial i troves gent superficial aparta ls, canvia d entorn.

Pq preguntem "quantitat o qualitat" i no "qualitat i mancança"?Perque qualitat i mancança no son antagonistes estan relacionats.
PQ si es bo n'hi ha poc,costa de trobar lo bo. si és dolent n'hi ha molt i n'hi ha molt pq no te valor, 
es el cami facil. Fer les coses be es el mes dificil i no hi ha moltes maneres possibles de ferho. 
Per aixo sembla tothom superficial, pq n hi ha mes pero no vols dia que no hi hagi connexions profundes, costen mes de trobar.

Volia compartir-ho perquè no vull que una persona com tu, si realment pensa aixi, es rendeixi o conformi. 
El codi es chatgtp encara no ho ser fer jo((( . 
Pots fer servir alguna en una conversa per calar a la gent.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        string[] preguntes = {
            "1. Quan coneixes algú nou, què t’atrau més al principi?\n a) Aparença externa\n b) Personalitat i valors",
            "2. En una amistat, què t’importa més?\n a) Divertit, interessant o popular\n b) Confiança i connexió profunda",
            "3. Quan et mires al mirall, què observes primer?\n a) Aspectes físics\n b) Com et sents per dins",
            "4. Quan tens temps lliure, què prefereixes fer?\n a) Xarxes, sèries, compres\n b) Llegir, reflexionar, aprendre",
            "5. Quan comets un error, què et preocupa més?\n a) Judici dels altres\n b) No actuar segons els teus valors",
            "6. Quan algú t’explica un problema, què fas primer?\n a) Donar solució ràpida\n b) Escoltar i entendre com se sent",
            "7. Quan veus un objecte de luxe o moda, què penses?\n a) Bonic o valuós\n b) Només superficial",
            "8. Quan planeges les teves metes, què domina més?\n a) Resultats visibles (diners, èxit)\n b) Creixement personal i satisfacció interna",
            "9. Quan tens un conflicte amb algú, què et preocupa més?\n a) La imatge o opinió dels altres\n b) Entendre i arreglar la relació",
            "10. Quan penses en el teu futur, què et fa més por?\n a) No tenir èxit o estatus\n b) No sentir-te realitzat",
            "11. Si et fan un regal, què valores més?\n a) Que sigui car o bonic\n b) Intenció i significat darrere",
            "12. Quan veus que algú fa una bona acció o aconsegueix èxit, què et provoca més emoció?\n a) Admiració externa\n b) Curiositat pel procés i valors",
            "13. Quan algú et parla d’una experiència vital, què fas?\n a) Fixa’t en detalls espectaculars\n b) Intenta comprendre emocions i significat",
            "14. Quan penses en la teva identitat, què domina?\n a) El que altres veuen o què tens\n b) Qui ets realment i valors",
            "15. Quan prens decisions, què pesa més?\n a) Imatge i reputació\n b) Principis i coherència interna"
        };

        int superficial = 0;
        int profund = 0;

        Console.WriteLine("Test de Superficialitat vs Profunditat\n");

        for (int i = 0; i < preguntes.Length; i++)
        {
            Console.WriteLine(preguntes[i]);
            Console.Write("Resposta (a/b): ");
            string resposta = Console.ReadLine().Trim().ToLower();

            while (resposta != "a" && resposta != "b")
            {
                Console.Write("Resposta no vàlida. Torna a escriure (a/b): ");
                resposta = Console.ReadLine().Trim().ToLower();
            }

            if (resposta == "a")
                superficial++;
            else
                profund++;

            Console.WriteLine();
        }

        Console.WriteLine("Resultats del test:");
        Console.WriteLine($"Respostes superficials: {superficial}");
        Console.WriteLine($"Respostes profundes: {profund}\n");

        if (superficial > profund)
            Console.WriteLine("Tens una tendència més superficial.");
        else if (profund > superficial)
            Console.WriteLine("Tens una tendència més profunda.Si vols parlarne 629 63 22 80, sempre whatsapp no tinc cobertura");
        else
            Console.WriteLine("Tens un equilibri entre superficialitat i profunditat.");

        Console.WriteLine("\nGràcies per fer el test!");
    }
}



