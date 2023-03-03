using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayı_aralığı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Bir A değeri giriniz: ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a >= 0 && a <= 50)
            {
                Console.WriteLine("Sayı 0-50 aralığında");
            }

            else
            {
                Console.WriteLine("Sayı 0-50 aralığında değil");
            }


            Console.ReadLine();
        }
    }
}
