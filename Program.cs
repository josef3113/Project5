using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Ex02.ConsoleUtils;

namespace Project5
{
        delegate void myMethod(double res);
    class Program
    {

        public static void DoubleIt(double todoubleThis)
        {
            double res = todoubleThis * todoubleThis;

            Console.WriteLine(res);

        }

        public static void Add2(double add2)
        {
            double res = add2 + 2;
            Console.WriteLine(res);

        }


        public static void Main()
        {
            Console.WriteLine("hello");
            Garage myGarage = new Garage();
            myGarage.OpenGrage();




            Console.ReadLine();
        }




    };


}
