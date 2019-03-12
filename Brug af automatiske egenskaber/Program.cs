using System;

namespace Brug_af_automatiske_egenskaber
{
    class Program
    {
        static void Main(string[] args)
        {



            Person p = new Person();
            p.Fornavn = "Mikkel";
            p.Efternavn = "Cronberg";
            Console.WriteLine(p.FuldtNavn());



            Console.WriteLine("Hello World!");
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class Person
    {
        public string Fornavn { get; set; }

        private string efternavn;

        public string Efternavn
        {
            get { return efternavn; }
            set
            {
                if (value.Length < 3)
                {
                    efternavn = "";
                }
                else
                {
                    efternavn = value;
                }
            }
        }

  
        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }
        // Metode eller egenskab?
        //Fuldt navn behøver ikke være en egenskab, da det er data, som ikke behøver at blive databundet, 
        //og derfor ikke brug for sikkerhed omkring det.

    }
}
