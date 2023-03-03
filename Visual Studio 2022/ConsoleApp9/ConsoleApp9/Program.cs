using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        private static int kupu(int sayi)
        {
            int kupdeger = sayi * sayi * sayi;
            return kupdeger;
        }
        static void Main(string[] args)
        {
            Console.Write("sayıyı girin: ");
            int s;
            s = Convert.ToInt32(Console.ReadLine());
            Console.Write("sonuç: " + kupu(s));
            Console.Read();
        }
    }
}
