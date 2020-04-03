using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A – adaugare oras\n" +
                "L – afisare date despre toate orasele\n" +
                "R – afisarea oraselor care apartin unei regiuni\n" +
                "D - afisarea distantelor dintre orase. Afisarea distantei maxime\n");
            string optiune;
            bool ok = true;
            do
            {
                Console.WriteLine("\nAlegeti o optiune: ");
                optiune = Console.ReadLine();
                Oras[] orase = new Oras[15];
                int NrOrase = 0;
                switch (optiune.ToUpper())
                {
                    case "A":
                        orase[NrOrase++] = CitireOrasTastatura();
                        break;
                    case "L":
                        for (int i = 0; i < NrOrase; i++)
                        {
                            Console.WriteLine(orase[i].ConversieLaSir());
                        }
                        break;
                    case "R":
                        orase[NrOrase] = new Oras("Suceava", 12, 15, Regiune.Moldova);
                        Console.WriteLine(orase[NrOrase].Info());
                        NrOrase++;
                        orase[NrOrase] = new Oras("Cluj", 20, 25, Regiune.Transilvania);
                        Console.WriteLine(orase[NrOrase].Info());
                        NrOrase++;
                        break;

                    case "D":
                        orase[0].DistantaFataDeAltOras(orase[1]);
                        break;
                    case "X":
                        ok = false;
                        break;
                    default:
                       Console.WriteLine("Optiune invalida");
                        break;

                }
            } while (ok == true);
            
        }

        public static Oras CitireOrasTastatura()
        {
            int x,y;
            Console.WriteLine("Introduceti denumirea orasului: ");
            string denumire = Console.ReadLine();

            Console.WriteLine("Introduceti coordonata x: ");
            string coordonataX = Console.ReadLine();
            bool success = Int32.TryParse(coordonataX, out x);
            if (!success)
                Console.WriteLine("Nu s-a realizat bine conversia");

            Console.WriteLine("Introduceti coordonata y: ");
            string coordonataY = Console.ReadLine();
            success = Int32.TryParse(coordonataY, out y);
            if (!success)
                Console.WriteLine("Nu s-a realizat bine conversia");

            Oras o = new Oras(denumire, x, y);
            return o;
        }
        
    }
}
