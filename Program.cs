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
            
            BordToGame currentGame = new BordToGame(8);
            currentGame.PrintBoardGame();

            //indexer suport that 
            currentGame['G', 'f'] = ' ';   //   player move white alfabetic sign
            currentGame['H', 'e'] = 'x';
            currentGame['A', 'f'] = ' ';
            currentGame['B', 'e'] = 'x';
            Console.WriteLine("{0}{0}after changes:{0}{0}",Environment.NewLine);

            currentGame.PrintBoardGame(); //  print board after changes 

            Console.ReadLine();

        }

        
        

    };


}
