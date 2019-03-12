using System;

namespace Arv__Udvid_System_Random_
{
    class Program
    {
        static void Main(string[] args)
        {

            UdvidetRandom r = new UdvidetRandom();
            Console.WriteLine(r.NextBool()); //true eller false




            Console.WriteLine("Hello World!");
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    public class UdvidetRandom : System.Random
    {
        public bool NextBool()
        {

            return this.Next(1, 1002) < 501;
        }
    }
    
}
