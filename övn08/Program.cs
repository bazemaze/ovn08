//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övn08
{
    const int arLength = 5;
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[arLength];
            //while (true)
            //{
                for (int i = 0; i < namn.Length; i++)
                {
                    Console.WriteLine("Ett namn: ");
                    namn[i] = Console.ReadLine();
                }
                PrintNames(namn);
                Console.WriteLine("Viljet index vill du byta namn på?");
                int indexByte = 0;
                try
                {
                    indexByte = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Nytt namn: ");
                namn[indexByte] = Console.ReadLine();
                PrintNames(namn);

                Console.WriteLine("Hur många mätningar har gjorts?: ");
                int antalMatn = 0;
                try
                {
                    antalMatn = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                int[] vader = new int[antalMatn];

                for (int i = 0; i < antalMatn; i++)
                {
                    Console.WriteLine($"Ange temp för {i}");
                    try
                    {
                        vader[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                double medel = Medel(vader);
                Console.WriteLine("medel: " + medel);


            //}

        }

        private static double Medel(int[] a)
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum - a.Length;
        }

        private static void PrintNames(string[] namn)
        {
            for (int i = namn.Length ; i >= 0; i--)
            {
                Console.WriteLine(namn[i]);
            }
        }
    }
}
