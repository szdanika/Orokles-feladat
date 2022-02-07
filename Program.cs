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
            Jarmu probamasik = new Jarmu(9, 9);
            Terkep terkep = new Terkep(80, 25);
            Jarmu probakocsi = new Helikopter(terkep,10, 10);
            //TerkepRajzolo rajzolo = new TerkepRajzolo(terkep);
            //rajzolo.Kirajzol();
            TerkepEsJarmuRajzolo raj = new TerkepEsJarmuRajzolo(terkep, 2);
            raj.JarmuFelvetele(probakocsi);
            raj.JarmuFelvetele(probamasik);
            raj.Kirajzol();
        }
        static void Teszt2()
        {
            Terkep terkep = new Terkep(80, 25);
            Jarmu probamasik = new Jarmu(9, 9);
            Jarmu probakocsi = new Helikopter(terkep, 10, 10);
            Szimulacio teszt = new Szimulacio(terkep, 2);
            teszt.JarmuFelvetele(probakocsi);
            teszt.JarmuFelvetele(probamasik);
            teszt.Fut();
        }

        static void Main(string[] args)
        {
            //Teszt1();
            Teszt2();
            Console.ReadLine();
        }
    }
}
