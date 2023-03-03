using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı;
            Console.Write("Lütfen sayıyı giriniz= ");
            Console.WriteLine();
            sayı = Convert.ToInt32(Console.ReadLine());

            if (sayı>=0)
            {
                Console.Write("Pozitif tam sayı girdiniz");
            }
            else
            {
                Console.Write("negatif tam sayı");
            }

            Console.ReadLine();
        }
    }
}
