using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    class Garage
    {
        MainMenue menue = new MainMenue("Garage Menue");

        public Garage()
        {

            menue.AddMethod("clos garag", CloseGarage);
            menue.AddMethod("insert car", InsertCar);
            menue.AddMethod("print car", PrintAllCar);
            SubMenue subMenue = new SubMenue("sub Menue");
            subMenue.AddMethod("clos garag from subMenue", CloseGarage);

            SubMenue subsubMenue = new SubMenue("subsub Menue");
            subsubMenue.AddMethod("print car from sub sub", PrintAllCar);

            subMenue.AddSubMenue(subsubMenue);



            menue.AddSubMenue(subMenue);

            
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
