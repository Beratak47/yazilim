using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayı_tahmin2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tahmin = 0, tutulan = 0;
            Random rasgele = new Random();
            tutulan = rasgele.Next(0, 11);
            while (tahmin != tutulan)
            {
               

                Console.WriteLine("Sayı giriniz");
                tahmin = Convert.ToInt32(Console.ReadLine());



            }

            Console.WriteLine("Tebrikler.");
            
            Console.Read();
        }
    }
}
