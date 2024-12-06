using System;
using System.Runtime.InteropServices;


namespace progtetelcig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, -5, 12, 5, 3, };
            

            //2.Maximum kivalasztas
            int max = x[0];
            int b;
            for (int b = 1; b < x.Length; b++) 
            {
                if (x[b] > max)
                {
                    max = x[b];
                }
            }

            Console.WriteLine("Maximum ertek:" + max);
            //1. Párosak kivalogatasa
            int n = x.Length;
            int i;
            int[] kimenet = new int[100];
            int db = 0;
            for (i=0; i < n; i++)
            {
                if (x[i] % 2 == 0)
                {
                    kimenet[db] = x[i];
                    db++;
                }
            }

            for (i = 0; i < n; i++)
            {
                Console.WriteLine(kimenet[i]+" ");
            }



        }
    }
}
