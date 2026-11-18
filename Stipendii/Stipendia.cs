using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stipendii
{
    public class Stipendia
    {
        private string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        private string vid;
        public string Vid
        {
            get { return vid; }
            set { vid = value; }
        }

        private double razmer;
        public double Razmer
        {
            get { return razmer; }
            set { razmer = value; }
        }

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

        private bool nakazania;
        public bool Nakazania
        {
            get { return nakazania; }
            set { nakazania = value; }
        }

        private double dohod;
        public double Dohod
        {
            get { return dohod; }
            set { dohod = value; }
        }

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

