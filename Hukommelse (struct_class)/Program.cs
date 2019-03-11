using System;

namespace Hukommelse__struct_class_
{
    class Program
    {

        struct Person
        {
            public int Id;
        }
        static void Main(string[] args)
        {

            Person k1 = new Person();
            Person k2 = new Person();
            k1.Id = 1;
            k2.Id = 2;
            Console.WriteLine(k1.Id);
            Console.WriteLine(k2.Id);

            k1 = k2;
            Console.WriteLine(k1.Id);
            Console.WriteLine(k2.Id);

            k1.Id = 3;
            Console.WriteLine(k1.Id);
            Console.WriteLine(k2.Id);














            Console.WriteLine("Hello World!");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
