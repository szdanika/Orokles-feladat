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
            Jarmu helikopater = new Helikopter(terkep, 10, 10);
            Szimulacio teszt = new Szimulacio(terkep, 2);
            teszt.JarmuFelvetele(helikopater);
            (helikopater as Helikopter).UjIranyVektor(1, 0);
            teszt.JarmuFelvetele(probamasik);
            teszt.Fut();
        }
        static void Teszt3()
        {
            Terkep terkep = new Terkep(80, 25);

            Jarmu probakocsi = new Jarmu(9, 9);

            Jarmu helikopater1 = new Helikopter(terkep, 10, 10);
            Jarmu helikopater2 = new Helikopter(terkep, 10, 15);

            Jarmu tank1 = new Tank(15, 15);
            Jarmu tank2 = new Tank(15, 10);

            Szimulacio test = new Szimulacio(terkep, 5);
            test.JarmuFelvetele(probakocsi);
            test.JarmuFelvetele(helikopater1);
            (helikopater1 as Helikopter).UjIranyVektor(1, 0);
            test.JarmuFelvetele(helikopater2);
            (helikopater2 as Helikopter).UjIranyVektor(1, 0);
            test.JarmuFelvetele(tank1);
            (tank1 as Tank).UjIranyVektor(1, 0);
            test.JarmuFelvetele(tank2);
            (tank2 as Tank).UjIranyVektor(1, 0);
            

            test.Fut();

        }
        static void Main(string[] args)
        {
            //Teszt1();
            Teszt3();
            Console.ReadLine();
        }
    }
}
