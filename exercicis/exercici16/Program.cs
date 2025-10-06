namespace exercici16;

/* Ningú entén res del nou sistema d’avaluació. Necessitem un programa que calculi la part que és més senzilla: 
a partir de la mitjana de les notes les pràctiques i la nota de l’examen ens calculi la nota final

Nota de pràctiques: 8
Nota de l’examen: 9
La nota final és 8.7 o sigui un 9

Nota de pràctiques: 10
Nota de l’examen: 5
La nota final és 6.5 o sigui un 7 
*/

class Program
{
    static void Main(string[] args)
    
    {
        Console.Write("Quina es la nota de practiques, posa decimals amb coma? ");  // amb coma perque sino no funciona
        float practiques = Convert.ToSingle(Console.ReadLine());         //float practiques = Convert.ToSingle(Console.ReadLine())

        Console.Write("Quina es la nota de l'examen, posa decimals amb coma? ");
        float examen = Convert.ToSingle(Console.ReadLine());


        float mitjana = (practiques + examen) / 2f;    // float perque sino no ens donara els decimals, l he hagut de forçar perque sino em donava error

        float notarrodonida = (float)Math.Round(mitjana, 0); // per arrodonir a numeros enter mes proper
        
        Console.WriteLine($" La nota final es {mitjana} o sigui {notarrodonida}");
    }
    }

