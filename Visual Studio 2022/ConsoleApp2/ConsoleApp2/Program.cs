using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, toplam, fark, carpim, bolum;

            Console.Write("**** ARİTMATİK 4 İŞLEM ****");
            Console.WriteLine();

            Console.Write("A değerini girin= ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("B değerini girin= ");
            b = Convert.ToInt32(Console.ReadLine());

            toplam = a + b;
            Console.WriteLine("toplam= " + toplam);
            Console.WriteLine();

            fark = a - b;
            Console.WriteLine("fark=" + fark);
            Console.WriteLine();

            carpim = a * b;
            Console.WriteLine("carpim=" + carpim);
            Console.WriteLine();

            bolum = a / b;
            Console.WriteLine("bolum=" + bolum);
            Console.WriteLine();

            Console.Read();
        }
    }
}
