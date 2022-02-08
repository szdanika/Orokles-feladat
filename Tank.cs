using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    sealed class Tank : Auto
    {
        public Tank(float x, float y) : base(x, y)
        {
            //uzemanyag = 100;
            azonosito = 'T';
        }
        int uzemanyag = 100;
        public override void Mozog()
        {
            if(uzemanyag >=10)
            {
                uzemanyag -= 10;
                base.Mozog();
            }
        }
        public override bool IdeLephet(float x, float y)
        {
            return true;
        }


    }
}
