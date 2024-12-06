using System;
using System.Runtime.InteropServices;


namespace progtetelcig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, -5, 12, 5, 3, };
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
                if (kimenet[i] > 0)
                {
                    Console.WriteLine(kimenet[i] + " ");
                }
            }





            Console.ReadKey();
            //2.Maximum
        }
    }
}
