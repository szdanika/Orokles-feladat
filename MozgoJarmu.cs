using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    abstract class MozgoJarmu : Jarmu
    {
        public float iranyX, iranyY;
        public MozgoJarmu(float X, float Y) : base(X, Y)
        {

        }
        public void UjIranyVektor(float iranyX, float iranyY)
        {
            this.iranyX = iranyX;
            this.iranyY = iranyY;
        }
        public abstract void Mozog();
    }
}
