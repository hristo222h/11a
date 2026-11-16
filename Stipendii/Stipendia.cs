using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stipendii
{
    public class Stipendia
    {
        public string Ime { get; set; }
        public string Vid { get; set; }
        public double Razmer { get; set; }

        private double uspeh;
        public double Uspeh
        {
            get { return uspeh; }
            set
            {
                if (value < 2 || value > 6)
                    throw new Exception("Nevaliden uspeh");
                uspeh = value;
            }
        }

        public bool Nakazania { get; set; }

        public double Dohod { get; set; }

        public Stipendia(string ime, string vid, double razmer, double uspeh, bool nakazania, double dohod)
        {
            Ime = ime;
            Vid = vid;
            Razmer = razmer;
            Uspeh = uspeh;
            Nakazania = nakazania;
            Dohod = dohod;
        }

        public void Izvejdane()
        {
            Console.WriteLine("Ime: " + Ime);
            Console.WriteLine("Vid stipendiq: " + Vid);
            Console.WriteLine("Razmer: " + Razmer);
            Console.WriteLine("Uspeh: " + Uspeh);
            Console.WriteLine("Nakazaniq: " + Nakazania);
            Console.WriteLine("Dohod: " + Dohod);
        }
        public void IzvejdaneOcenka()
        {
            Console.WriteLine($"{Ime} Uspeh: {Uspeh}");
        }
        public void IzvejdaneDohod()
        {
            Console.WriteLine($"{Ime} Dohod: {Dohod}");
        }

    }

}

