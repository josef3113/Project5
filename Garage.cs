using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    class Garage
    {
        MainMenue menue = new MainMenue();

        public Garage()
        {
            menue.AddMethod("clos garag", CloseGarage);
            menue.AddMethod("insert car", InsertCar);
            menue.AddMethod("print car", PrintAllCar);
        }

        public void OpenGrage()
        {
            menue.ShowMenue();
        }

        public void  InsertCar()
        {
            Console.WriteLine("insert car pleas");

        }

        public void CloseGarage()
        {
            Console.WriteLine("garage closing");
        }

        public void PrintAllCar()
        {
            Console.WriteLine("all car in garage");
        }
    }
}
