using System;
using System.Collections;
using System.Collections.Generic;

namespace Cwiczenia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int a;
            Llista<int> pesel = new Llista<int>();
            int[] lol = { 1, 3, 5 };
            int[] test = { 1, 2, 3 };
            //pesel.Add(5);
            //pesel.Add(1111111);
            //pesel.Remove(5);
            //a = pesel.Count();
            //  pesel.AddRange(lol);
            
            for (int i = 0; i < 203; i++)
             {
                    pesel.Add(i);
             }
            foreach (int item in pesel)
            {
                Console.WriteLine(item);
            }


            for (int i = 0; i < 102; i++)
            {
                pesel.Remove(i);
            }
            foreach (int item in pesel)
            {
                Console.WriteLine(item);
            }

            // Console.WriteLine(a);
            // pesel.AddRange(test);
            Console.WriteLine("------------------");
            foreach (int item in pesel)
            {
                Console.WriteLine(item);
            }
        }
    }
}
    
