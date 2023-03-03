using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tek_çift
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayı;
            Console.Write("Bir sayı giriniz: ");
            sayı = Convert.ToInt32(Console.ReadLine());

            if (sayı % 2 == 0)
            {
                Console.WriteLine("sayı çifttir");
            }
            else
            {
                Console.WriteLine("sayı tektir");
            }

            Console.ReadLine();
        }
    }
}
