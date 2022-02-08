using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Auto : MozgoJarmu
    {
        float sebeseg = 1;
        float aktualmagassag;
        public Auto(float x, float y) : base(x,y)
        {
            aktualmagassag = terkep.Magassag(x, y);
        }
        public override void Mozog()
        {
            float Ujx = x +(iranyX* sebeseg);
            float Ujy = y +(iranyY* sebeseg);
            if(terkep.Magassag(Ujx, Ujy) > aktualmagassag)
            {
                sebeseg = 0.5f;
            }
            else if(terkep.Magassag(Ujx, Ujy) < aktualmagassag)
            {
                sebeseg = 1.5f;
            }
            else { sebeseg = 1; }

            x = (float)Math.Ceiling(x + (iranyX * sebeseg));
            y = (float)Math.Ceiling(y + (iranyY * sebeseg));
        }
        public override bool IdeLephet(float x, float y)
        {
            return base.IdeLephet(x, y) && terkep.Magassag(x,y) > 0f;
        }
    }
}
