using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    class Garage
    {

        MainMenue m_menueOfGarag = new MainMenue("Garage Menue");

        public Garage()
        {

            m_menueOfGarag.AddMethod("clos garag", CloseGarage);
            m_menueOfGarag.AddMethod("insert car", InsertCar);
            m_menueOfGarag.AddMethod("print car", PrintAllCar);
            SubMenue subMenue = new SubMenue("sub Menue");
            subMenue.AddMethod("clos garag from subMenue", CloseGarage);

            SubMenue subsubMenue = new SubMenue("subsub Menue");
            subsubMenue.AddMethod("print car from sub sub", PrintAllCar);

            subMenue.AddSubMenue(subsubMenue);




            m_menueOfGarag.AddSubMenue(subMenue);


        }

        public void OpenGrage()
        {
            m_menueOfGarag.ShowMenue();
        }

        public void InsertCar()
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
