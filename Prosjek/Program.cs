using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProsjekOcjena
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            //varijable
            int brojOcjena=0, ocjena=0;
            double prosjek, zbrojOcjena = 0;

            //cilj programa
            Console.WriteLine("##########################");
            Console.WriteLine("# Izračunavanje prosjeka #");
            Console.WriteLine("##########################");
            Console.WriteLine("Za kraj unesite nulu.");

            //petlja za upis ocjena
            try
            {

                do
                {
                    Console.WriteLine("Unesite ocjenu:");
                    ocjena = Convert.ToInt32(Console.ReadLine());
                    if (ocjena > 1 && ocjena <= 5)
                    {
                        zbrojOcjena = zbrojOcjena + ocjena;
                        brojOcjena++;
                    }
                    else if (ocjena != 1 && ocjena != 0)
                    {
                        Console.WriteLine("Niste unesli broj između 1 i 5.");
                    }
                    if (ocjena == 1)
                    {
                        break;
                    }
                } while (ocjena != 0);
            }
            catch (Exception greska)
                {
                    Console.WriteLine("Neispravan unos, pokušajte ponovo.");
                    Console.WriteLine("Opis greške: " + greska.Message);
                }

                //slučaj padanja razreda
                if (ocjena == 1)
            {
                Console.WriteLine("Pali ste razred.");
            }

            //normalan prosjek
            else
            {
                prosjek = zbrojOcjena / brojOcjena;
                Console.WriteLine("Prosjek vam je:");
                Console.WriteLine(prosjek);
            }

            Console.ReadKey();
        }
    }
}
