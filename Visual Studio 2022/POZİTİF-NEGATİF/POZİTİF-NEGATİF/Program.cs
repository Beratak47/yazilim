using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POZİTİF_NEGATİF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı;
            Console.WriteLine("Lütfen bir sayı giriniz= ");
            sayı = Convert.ToInt32(Console.ReadLine());

            if (sayı >= 0)
            {
                Console.WriteLine("*Pozitif bir sayı girdiniz*");
            }
            else
            {
                Console.WriteLine("*negatif bir sayı girdiniz*");
            }

            
            
            
            
            
            
            Console.Read();
        }
    }
}
