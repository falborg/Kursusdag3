using System;

namespace Arrays__Simpel_
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] månedsløn = { 10000, 20000, 15000, 20000, 30000, 15000 };
            double sum = 0;
            for (int i = 0; i< månedsløn.Length; i++)
            {
                sum += månedsløn[i];
                Console.WriteLine(månedsløn[i]);

            }
            

            double gns = sum / månedsløn.Length;
            Console.WriteLine("Gennemsnit " + gns.ToString("N2"));

            //Sortering: HEY - det her har jeg selv fundet ud af. Det stod ikke i løsningen!!Success!!
            int[] b = månedsløn.Clone() as int[];
            System.Array.Sort(b);
            //return b[];
            Console.WriteLine(string.Join(' ',b));



            Console.WriteLine("Hello World!");
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }


}
