using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class emlak
    {
        private string semt;
        private string renk;
        private int odasayisi;
        private int katno;
        private double alan;


        public string SEMTİ
        {
            get { return semt; }
            set { semt = value.ToUpper(); }
        }
        public string RENGİ
        {
            get { return renk; }
            set { renk = value.ToLower(); }
        }

        public int ODASAYISI
        {
            get { return odasayisi; }
            set { odasayisi = Math.Abs(value); }
        }
        public int KATNO
        {
            get { return katno; }
            set { katno = Math.Abs(value); }
        }
        public double ALAN
        {
            get { return alan; }
            set { alan = Math.Abs(value); }
        }

        

       
    }
}
