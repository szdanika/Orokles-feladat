using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Szimulacio : TerkepEsJarmuRajzolo
    {
        public Szimulacio(Terkep terkep, int meret) : base(terkep, meret)
        {

        }
        public void EgyIdoEgysegEltelt()
        {
            for(int i = 0; i < jarmuvek.Length; i++)
            {
                if(jarmuvek[i] is MozgoJarmu)
                {
                    jarmuvek[i].Mozog();
                }
            }
        }
    }
}
