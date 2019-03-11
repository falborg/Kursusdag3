using System;

namespace Fejlhååndtering__egen_exception_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine(SmartToUpper("mikkel"));


            try
             {
                 Console.WriteLine(SmartToUpper("mikkel"));
                 Console.WriteLine(SmartToUpper("mAtHiAs"));

                 // prøv også 
                 Console.WriteLine(SmartToUpper(""));
                 // eller
                 Console.WriteLine(SmartToUpper(null));

             }
             catch (Exception ex)
             {
                 Console.WriteLine("Der er sket en fejl: " + ex.Message);
             }
             



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }

        private static string SmartToUpper(string tekst)
            {



                if (tekst == null)
                {
                    throw new ApplicationException("tekst må ikke være null");
                }

                if (tekst == "")
                {
                    throw new ApplicationException("tekst må ikke være tom");
                }
                
                string tmp = tekst.ToLower();
                string resultat = tmp.Substring(0, 1).ToUpper() + tmp.Substring(1);
                return resultat;
            }








            
        }





}
