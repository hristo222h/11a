using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11zadMVC
{
    public class View
    {

        public int Count { get; set; }
        public string Size { get; set; }

        public string Nachin { get; set; }
        public double Total { get; set; }

        public void Input()
        {
            Console.Write("vuvedete broi snimki: ");
            Count = int.Parse(Console.ReadLine());
            Console.Write("vuvedete razmer na snimkata: ");
            Size = Console.ReadLine();
            Console.Write("vuvedi nachin za poruchka (online/office): ");
            Nachin = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine($"total = {Total}BGN");
        }

    }
}
