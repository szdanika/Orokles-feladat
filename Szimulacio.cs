using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Szimulacio : TerkepEsJarmuRajzolo
    {
        Terkep t;
        public Szimulacio(Terkep terkep, int meret) : base(terkep, meret)
        {
            t = terkep;
        }
        public void EgyIdoEgysegEltelt()
        {
            for(int i = 0; i < jarmuvek.Length; i++)
            {
                if(jarmuvek[i] is MozgoJarmu)
                {
                    (jarmuvek[i] as MozgoJarmu).Mozog();
                }
            }
        }
        public void Fut()
        {
            while (true)
            {
                EgyIdoEgysegEltelt();
                Kirajzol();
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
