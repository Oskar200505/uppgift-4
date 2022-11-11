using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_4
{
    internal class Djur
    {

        private string namn;
        private string ålder;
        public string getNamn()
        {
            return this.namn;
        }
        public void setNamn(string namn)
        {
            this.namn = namn;
        }
        public class Hund : Djur
        {
            private int svansenslängd;

            public int getSvansenslängd()
            {
                return this.svansenslängd;
            }

            public void setsvansenslängd(int svansenslängd)
            {
                this.svansenslängd = svansenslängd;
            }
       
            public void skäll()
            {
                Console.WriteLine("rrrrufffh");
            }
        }
    }
}
