using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123124
{
    internal class Program
    {
        private static void veriler()
        {
            Console.WriteLine("Başkan: Ali koç");
            Console.WriteLine("T.D: Jorge Jesus");
            Console.WriteLine("Takım: Fenerbahçe S.K");
            Console.WriteLine("Stadyum: Fenerbahçe ATATÜRK Stadyumu");
            Console.WriteLine(DateTime.Now.ToLongDateString());
        }
        static void Main(string[] args)
        {
            veriler();
            Console.Read();
        }
    }
}
