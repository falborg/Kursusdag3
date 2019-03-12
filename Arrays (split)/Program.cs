using System;

namespace Arrays__split_
{
    class Program
    {
        static void Main(string[] args)
        {



            string txt = "3;5;22;1;10;15;5";
            string[] numre = txt.Split(';');
            int sum = 0;
            for (int i = 0; i< numre.Length; i++)
            {
                int tal = Convert.ToInt32(numre[i]);
                sum += tal;
            }


            Console.WriteLine($"Summen er {sum:N2}");





            Console.WriteLine("Hello World!");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
