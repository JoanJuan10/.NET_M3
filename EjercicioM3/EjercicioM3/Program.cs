using System;

namespace EjercicioM3
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1, string2, string3, string4, string5, string6;

            Console.WriteLine("Escriu una ciutat");
            string1 = Console.ReadLine();
            Console.WriteLine("Escriu una ciutat");
            string2 = Console.ReadLine();
            Console.WriteLine("Escriu una ciutat");
            string3 = Console.ReadLine();
            Console.WriteLine("Escriu una ciutat");
            string4 = Console.ReadLine();
            Console.WriteLine("Escriu una ciutat");
            string5 = Console.ReadLine();
            Console.WriteLine("Escriu una ciutat");
            string6 = Console.ReadLine();

            Console.WriteLine("CIUTATS:");
            Console.WriteLine(string1);
            Console.WriteLine(string2);
            Console.WriteLine(string3);
            Console.WriteLine(string4);
            Console.WriteLine(string5);
            Console.WriteLine(string6);

            string[] arrayCiutats = { string1, string2, string3, string4, string5, string6 };
            Array.Sort(arrayCiutats);

            Console.WriteLine("ORDENATS:");
            for (int i = 0; i < arrayCiutats.Length; i++)
            {
                Console.WriteLine(arrayCiutats[i]);
            }

            string[] arrayCiutatsModificades = new string[arrayCiutats.Length];
            for (int i = 0; i < arrayCiutats.Length; i++)
            {
                arrayCiutatsModificades[i] = arrayCiutats[i].Replace('a','4');
            }

            Console.WriteLine("MODIFICATS:");
            for (int i = 0; i < arrayCiutatsModificades.Length; i++)
            {
                Console.WriteLine(arrayCiutatsModificades[i]);
            }



        }
    }
}
