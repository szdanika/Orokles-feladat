using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Helikopter : MozgoJarmu
    {
        float sebeseg = 1;
        public Helikopter(Terkep terkep, float x, float y) : base(x,y)
        {
            azonosito = 'H';
        }
        public void Gyorsit()
        {
            sebeseg += 0.1f;
        }
        public void Lassit()
        {
            if (sebeseg >= 0.1)
                sebeseg -= 0.1f;
        }
        public override void Mozog()
        {
            if(IdeLephet(x+1,y+1))//IdeLephet(iranyX * sebeseg, iranyY * sebeseg))
            {
                //x = iranyX * sebeseg;
                //y = iranyY * sebeseg;

                x = x + 1;
                y = y + 1;
            }
        }
    }
}
