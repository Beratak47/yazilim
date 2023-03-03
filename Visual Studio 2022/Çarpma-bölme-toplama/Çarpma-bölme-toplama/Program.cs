using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çarpma_bölme_toplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, toplam, carpma, bolum;
            Console.Write("**Toplama,Çarpma,Bölme**");
            Console.WriteLine();
            Console.Write("A değeri girin= ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B değeri girin= ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            toplam = a + b;
            Console.WriteLine("Toplam= " + toplam );
            carpma = a * b;
            Console.WriteLine("carpım= " + carpma);
            bolum = a / b;
            Console.WriteLine("bolum= " + bolum);
            

            Console.Read();
        }
    }
}
