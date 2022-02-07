using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Jarmu
    {
        public char azonosito = '*';
        protected float x, y;
        Terkep terkep;
        public Jarmu(float X, float Y)
        {
            terkep = new Terkep(80,25);
            x = X;
            y = Y;
        }
        public float X { get =>x; }
        public float Y { get =>y; }
        public virtual bool IdeLephet(float x, float y)
        {
            return terkep.TerkepenBeluliPozicio(x,y);
        }
    }
}
