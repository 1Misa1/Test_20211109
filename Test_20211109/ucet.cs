using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_20211109
{
    public class ucet
    {
        private int vlozeno;
        public string Jmeno { get; }
        public int Aktualneucet { get; }
        public int Vlozeno { get => vlozeno; }

        public ucet(string jmeno, int aktualneucet)
        {
            Jmeno = jmeno;
            Aktualneucet = aktualneucet;
        }

        public int Vlozit(int stav)
        {
            var penize = Aktualneucet - vlozeno;
            if (penize > stav)
            {
                vlozeno += stav;
                return stav;
            }
            else
            {
                vlozeno += penize;
                return vlozeno;
            }

        }

        public int Vyber(int stav)
        {
            if (stav > Vlozeno)
            {
                var aktualnistav = stav;
                stav = 0;
                return aktualnistav;
            }
            else
            {
                vlozeno -= stav;
                return stav;
            }
        }
        public int Platba(int platba)
        {
            if (platba > Vlozeno)
            {
                var aktualnistav = platba;
                platba = 0;
                return aktualnistav;
            }
            else
            {
                vlozeno -= platba;
                return platba;
            }
        }

    }
}
