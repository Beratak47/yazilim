using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int şifre;
            Console.Write("şifreyi girin: ");
            şifre = Convert.ToInt32(Console.ReadLine());
            bool durum1 = şifre == 1234;
            Console.Write("şifre doğru mu {0}", durum1);
            Console.Read();
        }
    }
}
