using System;

namespace Klasser__simpel_klasse_
{
    class Program
    {

       

        static void Main(string[] args)
        {

            //Brug klassen i Main ved at skabe 2-3 objekter med new og test at metoderne virker.

            Person p1 = new Person();
            p1.Efternavn = "cronberg";
            p1.Fornavn = "mathias";
            p1.Fødselsår = 2006;
            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.Alder());



            Person p2 = new Person("mikkel", "cronberg", 2009);
            Console.WriteLine(p2.FuldtNavn());
            Console.WriteLine(p2.Alder());






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
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;

        public string FuldtNavn()
        {
            return $" {Fornavn} {Efternavn}";
        }

        public int Alder()
        {
            int år = DateTime.Now.Year;
            return år - this.Fødselsår;
        }

        //default constructor
        public Person()
        {
            this.Fornavn = "";
            this.Efternavn = "";
        }

        //custom constructor
        public Person(string fornavn, string efternavn, int fødselsår)
        {
            this.Fødselsår = fødselsår;
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;

        }


    }
}
