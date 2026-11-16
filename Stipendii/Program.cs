using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stipendii
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                Stipendia s1 = new Stipendia("Petar", "Otlichen uspeh",25 ,5.68, false, 600);
                s1.Izvejdane();
                Console.WriteLine();

                Console.Write("Broi uchenici: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine();

                List<Stipendia> uchenici = new List<Stipendia>();

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Uchenik {i + 1}: ");

                    Console.Write("Ime: ");
                    string ime = Console.ReadLine();

                    Console.Write("Vid stipendiq: ");
                    string vid = Console.ReadLine();

                    Console.Write("Razmer: ");
                    double razmer = double.Parse(Console.ReadLine());

                    Console.Write("Uspeh: ");
                    double uspeh = double.Parse(Console.ReadLine());

                    Console.Write("Ima nakazanie (da/ne): ");
                    bool nakazania = Console.ReadLine().ToLower() == "da";

                    Console.Write("Dohot na chlen ot semeistvoto: ");
                    double dohod = double.Parse(Console.ReadLine());

                    uchenici.Add(new Stipendia(ime, vid, razmer, uspeh, nakazania, dohod));
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("Izvejdane na inf za vseki edin uchenik ot lista:");
                foreach (var u in uchenici)
                {
                    u.Izvejdane();
                    Console.WriteLine();
                }

                Console.WriteLine("Uchenici s uspeh nad 4.50: ");
                var dobri = uchenici.Where(x => x.Uspeh > 4.50);
                foreach (var u in dobri)
                {
                    u.IzvejdaneOcenka();
                }
                Console.WriteLine();

                var naiDobur = uchenici.OrderByDescending(x => x.Uspeh).FirstOrDefault();
                Console.WriteLine("Uchenici s nai visok uspeh: ");
                if (naiDobur != null)
                {
                    naiDobur.IzvejdaneOcenka();
                }
                Console.WriteLine();

                Console.WriteLine("Sortirane po semeen dohod: ");
                var sortirani = uchenici.OrderBy(x => x.Dohod);
                foreach (var u in sortirani)
                {
                    u.IzvejdaneDohod();
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greshka: " + ex.Message);
            }
        }
    }

}
    

