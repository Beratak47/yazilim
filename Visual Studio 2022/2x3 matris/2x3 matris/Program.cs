using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2x3_matris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] dizi = new int[2, 3];
            dizi[0, 0] = 5;
            dizi[0, 1] = 8;
            dizi[0, 2] = 10;
            dizi[1, 0] = 20;
            dizi[1, 1] = 17;
            dizi[1, 2] = 35;

            for(int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(" {0} ", dizi[i, j]);
                Console.WriteLine();
            }
            Console.Read();

        }
    }
}
