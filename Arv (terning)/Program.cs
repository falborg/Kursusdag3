using System;

namespace Arv__terning_
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Hello World!");
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
    // Denne del handler om den del af opgaven, som ligger i terningeopgaven under modulet Polymorfi.
    //Du skal skabe en tom konsol app med en klasse Terning med følgende medlemmer:
    public class Terning
    {

        //En offentlig egenskab(int) Værdi(med private felt kaldet værdi). Der må ikke tildeles et tal mindre en den eller større end seks. Hvis det sker, sættes værdi blot til en.
        public int Værdi { get; set; }

        //For løsning, tryk på linket i opgaven og åbn den fil, der hedder LudoTerning.cs på GitHub.


        //En privat statisk instans af System.Random (initialiseres i en statisk constructor)
        //En offentlig metode Ryst() der giver et tilfældigt tal
        //En Offentlig metode Skriv() der viser terningen(eksempelvis[1] eller [2])
        //Tilføj en default constructor(hvor Ryst kaldes) og en custom constructor hvor værdi kan angives når der oprettes en instans.
        //Skab nu en ny klasse LudoTerning der arver fra Terning.Klassen har to metoder

        //ErGlobus() returnerer true hvis værdien er 3 – ellers false
        //ErStjerne() returnerer true hvis værdien er 5 – ellers false
        //Sørg for at der både er en default og custom constructor der kalder ”mor” uden yderligere funktionalitet
        //Sørg for at Skriv kan overskrives så den returnerer eksempelvis [1] [2] [G] [4] [S] [6]
        //Prøv at skabe instanser af både Terning og LudoTerning og test at metoder fungerer.

        //Ekstra:

        //Der skal logges (console.writeline) når der aflæses og tildeles en værdi.
    }
}
