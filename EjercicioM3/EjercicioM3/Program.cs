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
                arrayCiutatsModificades[i] = arrayCiutats[i].Replace('a', '4');
            }

            Console.WriteLine("MODIFICATS:");
            for (int i = 0; i < arrayCiutatsModificades.Length; i++)
            {
                Console.WriteLine(arrayCiutatsModificades[i]);

            }
            char[] ciutat1 = new char[arrayCiutats[0].Length];
            char[] ciutat2 = new char[arrayCiutats[1].Length];
            char[] ciutat3 = new char[arrayCiutats[2].Length];
            char[] ciutat4 = new char[arrayCiutats[3].Length];
            char[] ciutat5 = new char[arrayCiutats[4].Length];
            char[] ciutat6 = new char[arrayCiutats[5].Length];

            for (int i = 0; i < arrayCiutats.Length; i++)
            {
                for (int j = 0; j < arrayCiutats[i].Length; j++)
                {
                    switch (i)
                    {
                        case 0:
                            ciutat1[j] = arrayCiutats[i][j];
                            break;
                        case 1:
                            ciutat2[j] = arrayCiutats[i][j];
                            break;
                        case 2:
                            ciutat3[j] = arrayCiutats[i][j];
                            break;
                        case 3:
                            ciutat4[j] = arrayCiutats[i][j];
                            break;
                        case 4:
                            ciutat5[j] = arrayCiutats[i][j];
                            break;
                        case 5:
                            ciutat6[j] = arrayCiutats[i][j];
                            break;
                    }
                }
            }
            Console.WriteLine("AL REVES:");
            MostrarCiutatReves(ciutat1);
            MostrarCiutatReves(ciutat2);
            MostrarCiutatReves(ciutat3);
            MostrarCiutatReves(ciutat4);
            MostrarCiutatReves(ciutat5);
            MostrarCiutatReves(ciutat6);

        }
        static void MostrarCiutatReves (char[] ciutat)
        {
            for (int i = ciutat.Length - 1; i >= 0; i--)
            {
                Console.Write(ciutat[i]);
            }
            Console.WriteLine();
        }
    }
}
