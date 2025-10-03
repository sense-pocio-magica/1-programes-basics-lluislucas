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
        Console.Write("Quina es la nota de practiques, posa decimals amb coma? ");
        float practiques = float.Parse(Console.ReadLine());

        Console.Write("Quina es la nota de l'examen, posa decimals amb coma? ");
        float examen = float.Parse(Console.ReadLine());


        float mitjana = (practiques + examen) / 2f;

        float notarrodonida = (float)Math.Round(mitjana, 0);
        
        Console.WriteLine($" La nota final es {mitjana} o sigui {notarrodonida}");
    }
    }

