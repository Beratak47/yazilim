using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30danbüyük
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int büyük30 = 0;
            int sayi;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0}. sayıyı girin : ", i);
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi <= 30)
                {
                    büyük30++;
                }

            }
            Console.WriteLine("*******");
            Console.WriteLine("{0} tane 30 dan hüçük sayı girdiniz", büyük30);
            Console.Read();
        }
    }
}
