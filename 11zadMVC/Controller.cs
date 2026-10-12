using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11zadMVC
{
    public class Controller
    {

        private Model model;
        private View view;

        public Controller()
        {
            model = new Model();
            view = new View();
        }

        public void Run()
        {
            view.Input();

            model.Count = view.Count;
            model.Size = view.Size;
            model.Nachin = view.Nachin;

            model.Calculate();

            view.Total = model.Total;
            view.Output();

        }
    }
}
