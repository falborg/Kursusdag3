using System;

namespace Klasser__Terning_
{
    class Terning
    {
        //En offentlig (public) int værdi
        public int værdi;

        //En privat (private) bool snyd
        private bool snyd;

        //En privat (private) statisk (static) og ny instans af System.Random kaldet rnd
        private static Random rnd = new Random();

        //En metode Skriv() som udskriver værdien (evt som [2] eller [4])
        public void Skriv()
        {
            Console.WriteLine("[" + this.værdi + "]");
        }

        //En default constructor der sætter værdi til 1 og snyd til false
        public Terning(bool snyd)
        {
            this.snyd = snyd;
            Ryst();
        }

        //En metode Ryst() som sætter værdi til en tilfældig værdi mellem 1-6 rnd.Next(1,7).
        //Dette skal dog kun ske hvis snyd = false. Hvis snyd = true så skal værdi sættes til 6.
        public void Ryst()
        {
            if (snyd)
                this.værdi = 6;
            else
                this.værdi = rnd.Next(1, 7);
        }

        //En custom constructor med en bool argument, der sætter værdi til en 1 og snyd til den givne værdi
        public Terning():this(false)
        {

        }

    }
    
}
