using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11zadMVC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Controller controller = new Controller();
            controller.Run();

            //Console.Write("vuvedete broi snimki: ");
            //int count = int.Parse(Console.ReadLine());
            //Console.Write("vuvedete razmer na snimkata: ");
            //string size = Console.ReadLine();
            //Console.Write("vuvedi nachin za poruchka (online/office): ");
            //string nachin = Console.ReadLine();

            //double price = 0;
            //double discount = 0;

            //switch (size)
            //{

            //    case "9x13":
            //        price = 0.16;
            //        if (count >= 50)
            //        {
            //            discount = 0.05;
            //        }
            //        break;
            //    case "10x15":
            //        price = 0.16;
            //        if (count >= 80)
            //        {
            //            discount = 0.03;
            //        }
            //        break;
            //    case "13x18":
            //        price = 0.38;
            //        if (count >= 50 && count <= 100)
            //        {
            //            discount = 0.03;
            //        }
            //        if (count > 100)
            //        {
            //            discount = 0.05;
            //        }
            //        break;
            //    case "20x30":
            //        price = 2.90;
            //        if (count >= 10 && count <= 50)
            //        {
            //            discount = 0.07;
            //        }
            //        if (count > 50)
            //        {
            //            discount = 0.09;
            //        }
            //        break;
            //}

            //double total = price * count;
            //total = total * (1 - discount);

            //if (nachin == "online")
            //{
            //    total = total * 0.98;
            //}

            //Console.WriteLine($"total: {total}BGN");


        }
    }
}
