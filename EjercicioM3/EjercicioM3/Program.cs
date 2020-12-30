using System;

namespace EjercicioM3
{
    class Program
    {
        static void Main(string[] args)
        {
            Milestone3();

        }
        static void Milestone1 ()
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
        static void Milestone2 ()
        {
            int[,] alumnes = new int[5,3];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Introdueix la nota {0} del alumne {1}", (j + 1), (i + 1));
                    int nota = Convert.ToInt32(Console.ReadLine());
                    if (nota < 0)
                    {
                        Console.WriteLine("La nota introduida es massa petita, cambiat a 0");
                        nota = 0;
                    }
                    else if (nota > 10)
                    {
                        Console.WriteLine("La nota introduida es massa gran, cambiat a 10");
                        nota = 10;
                    }
                    alumnes[i,j] = nota;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                int mitjana = 0;
                for (int j = 0; j < 3; j++)
                {
                    mitjana += alumnes[i,j];
                }
                mitjana /= 3;
                Console.WriteLine("Alumne {0}:", i);
                if (mitjana < 5)
                {
                    Console.WriteLine("SUSPES!");
                }
                else
                {
                    Console.WriteLine("APROBAT!");
                }
            }
        }
        static void Milestone3()
        {
            Console.WriteLine("Numero al qual arribar: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int numeroFibonachi = 1;
            int num1 = 0;
            int num2 = 1;
            Console.Write("Fibonachi: 0,1,");

            while (numeroFibonachi < numero)
            {
                numeroFibonachi = num1 + num2;
                num1 = num2;
                num2 = numeroFibonachi;
                if (numeroFibonachi < numero)
                {
                    Console.Write(numeroFibonachi + ",");
                }
            }
        }
    }
}
