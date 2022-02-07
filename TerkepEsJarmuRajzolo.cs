using System;

namespace Orokles
{
    class TerkepEsJarmuRajzolo : TerkepRajzolo
    {
        protected Jarmu[] jarmuvek;
        int jarmuvekN;
        public TerkepEsJarmuRajzolo(Terkep terkep, int meret) : base(terkep)
        {
            jarmuvek = new Jarmu[meret];
        }
        public void JarmuFelvetele(Jarmu jarmu)
        {
            jarmuvek[jarmuvekN] = jarmu;
            jarmuvekN++;
        }
        protected override char MiVanItt(int x, int y) //os osztalyban chart add vissza
        {
            for(int i = 0; i < jarmuvek.Length; i++)
            {
                if(jarmuvek[i].X == x && jarmuvek[i].Y == y)
                {
                    return jarmuvek[i].azonosito;
                }
            }
            return ' ';
        }

    }
}
