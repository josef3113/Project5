using System;
using System.Collections.Generic ;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Ex02.ConsoleUtils;

namespace Project5
{
    class Program
    {


        public static void Main()
        {


            BordToGame stam  = new BordToGame(8);
            stam.PrintBoardGame();

            stam['f', 'A'] = ' ';
            stam.PrintBoardGame();


        }


        public enum eChoisForSizeGame : byte
        {
            
            SizeIs6 = 1,
            SizeIs8,
            SizeIs10
        }



            };


}
