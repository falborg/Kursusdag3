﻿using System;

namespace Komplete_egenskaber
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //Vare v = new Vare();
            //v.Navn = "vare #1";
            //v.Pris = 100;
            //Console.WriteLine(v.PrisMedMoms());

            Vare v2 = new Vare("vare #2", 200);
            Console.WriteLine(v2.PrisMedMoms());


            Console.WriteLine("Hello World!");
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }


        }
        
}

    public class Vare
    {
        public Vare(string Navn, double Pris)
        {
            this.Pris = Pris;
            this.Navn = Navn;
        }
        private string navn;
        public string Navn
        {
            get
            {
                Console.WriteLine("Nu aflæses navn");
                return navn;

            }

            set
            {
                Console.WriteLine("Nu tildeles navn");
                navn = value;


            }
        }

        private double pris;
        public double Pris
        {
            get
            {
                Console.WriteLine("Nu aflæses pris");
                return pris;
            }

            set
            {
                Console.WriteLine("Nu tildelse pris");
                pris = value;
            }

        }

        public double PrisMedMoms()
        {
            return this.pris = 1.25;
        }
    }

}
