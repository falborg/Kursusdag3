using System;

namespace Arv__simpel_
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person() { Efternavn = "x", Fornavn = "y" };
            Elev e = new Elev() { Efternavn = "t", Fornavn = "g", Klasselokale = "Søndergade" };
            Instruktør i = new Instruktør() { Efternavn = "2", Fornavn = "s", NøgleId = 1 };

            Console.WriteLine(p.FuldtNavn());
            Console.WriteLine(e.FuldtNavn());
            Console.WriteLine(i.FuldtNavn());



            Console.WriteLine("Hello World!");
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
    public class Person
    {
        public string Fornavn { get; set; }

        public string Efternavn { get; set; }

        public string FuldtNavn()
        {
            return $"{Fornavn} {Efternavn}";
        }

    }

    public class Elev : Person
    {
        public string Klasselokale { get; set; }
        
    }

    public class Instruktør : Person
    {
        public int NøgleId { get; set; }
       
    }
 
}
