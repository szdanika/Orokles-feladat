using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Program
    {
        static void Teszt1()
        {
            Jarmu probakocsi = new Jarmu(10, 10);
            Jarmu probamasik = new Jarmu(9, 9);
            Terkep terkep = new Terkep(80, 25);
            //TerkepRajzolo rajzolo = new TerkepRajzolo(terkep);
            //rajzolo.Kirajzol();
            TerkepEsJarmuRajzolo raj = new TerkepEsJarmuRajzolo(terkep, 2);
            raj.JarmuFelvetele(probakocsi);
            raj.JarmuFelvetele(probamasik);
            raj.Kirajzol();

        }

        static void Main(string[] args)
        {
            Teszt1();
            Console.ReadLine();
        }
    }
}
