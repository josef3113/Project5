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
            //currentGame.PrintBoardGame();

            //currentGame.FlipToKing("Af");
            //currentGame.FlipToKing("Ba");

            ////indexer suport that 
            //currentGame['G', 'f'] = ' ';   //   player move white alfabetic sign
            //currentGame['H', 'e'] = 'x';

            //Console.WriteLine("{0}{0}after changes:{0}{0}",Environment.NewLine);

            //currentGame.PrintBoardGame(); //  print board after changes 

            currentGame.creatActivity();
            currentGame.PrintVeelssOfComputer();
            currentGame.ChanghVeessl("af", "df");
            Console.WriteLine("after");
            currentGame.PrintVeelssOfComputer();
            Console.ReadLine();

        }

        
        

    };


}
