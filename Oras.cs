using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    enum Regiune {Moldova,Transilvania,Muntenia,Dobrogea};
    class Oras
    {
        string denumire;
        int x;
        int y;
        Regiune regiune;

        public Oras()
        {

        }
        public Oras(string _denumire, int _x, int _y, Regiune _regiune)
        {
            denumire = _denumire;
            x = _x;
            y = _y;
            regiune = _regiune;
        }
        public Oras(string _denumire, int _x, int _y)
        {
            denumire = _denumire;
            x = _x;
            y = _y;
        }
        public double DistantaFataDeAltOras(Oras o1)
        {
            double distanta = Math.Sqrt(((x - o1.x) * (x - o1.x)) + ((y - o1.y) * (y - o1.y)));
            return distanta;
        }
        public string Info()
        {
            string sir;
            if (denumire == null || x == 0 || y == 0 || regiune == null)
                sir=string.Format("Introduceti datele despre un oras prima data");
            else
                sir = string.Format("Orasul {0} are coordonatele :{1}-{2} si face parte din regiunea {3}", denumire, x, y, regiune);
            return sir;
        }
        public string ConversieLaSir()
        {
            string sir;
            if (denumire == null || x == 0 || y == 0 )
                sir = string.Format("Introduceti datele despre un oras prima data");
            else
                sir = string.Format("Orasul {0} are coordonatele :{1}-{2}", denumire, x, y);
            return sir;
        }

    }
}
