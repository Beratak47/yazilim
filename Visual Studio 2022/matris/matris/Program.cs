using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int satir, sutun;
            Console.Write("satır sayısını girin: ");
            satir = Convert.ToInt32(Console.ReadLine());
            Console.Write("sütün sayısı girin: ");
            sutun = Convert.ToInt32(Console.ReadLine());
            int[,] matris = new int[satir, sutun];

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write("matrisin {0} x {1} değeri: ", i + 1, j + 1);
                    matris[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();

            for (int k = 0; k < satir; k++)
            {
                for (int n = 0; n < sutun; n++)
                {
                    Console.Write(matris[k, n] + " ");
                }
                Console.WriteLine();
            }
            //transpoze
            Console.WriteLine();
            for (int x = 0; x < satir; x++)
            {
                for(int y = 0; y < sutun; y++)
                {
                    Console.Write(matris[y, x] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //kat sayı ile çarpımı

            for (int s = 0; s < satir; s++)
            {
                for (int p = 0; p < sutun; p++)
                {
                    Console.Write(matris[s, p] * 5 + " ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
