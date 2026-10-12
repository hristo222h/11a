using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11zadMVC
{
    public class Model
    {
		private int count;

		public int Count
		{
			get { return count; }
			set { count = value; }
		}
		private string size;

		public string Size
		{
			get { return size; }
			set { size = value; }
		}

		private string nachin;

		public string Nachin
		{
			get { return nachin;; }
			set { nachin = value; }

		}
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private double discount;

        public double Discount 
        {
            get { return discount; }
            set { discount = value; }
        }


        private double total;

		public double Total
		{
			get { return total; }
			set { total = value; }
		}

        public void Calculate()
		{

            switch (size)
            {

                case "9x13":
                    price = 0.16;
                    if (count >= 50)
                    {
                        discount = 0.05;
                    }
                    break;
                case "10x15":
                    price = 0.16;
                    if (count >= 80)
                    {
                        discount = 0.03;
                    }
                    break;
                case "13x18":
                    price = 0.38;
                    if (count >= 50 && count <= 100)
                    {
                        discount = 0.03;
                    }
                    if (count > 100)
                    {
                        discount = 0.05;
                    }
                    break;
                case "20x30":
                    price = 2.90;
                    if (count >= 10 && count <= 50)
                    {
                        discount = 0.07;
                    }
                    if (count > 50)
                    {
                        discount = 0.09;
                    }
                    break;
            }

            total = price * count;
            total = total * (1 - discount);

            if (nachin == "online")
            {
                total = total * 0.98;
            }

        }

	}
}
