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
            DamkaGame currentGame = new DamkaGame(6);
            currentGame.PrintBoardGame();
            Console.WriteLine("insert your active");
            currentGame.Active();
            //currentGame['G', 'f'] = ' ';   //   player move white alfabetic sign
            //currentGame['H', 'e'] = 'x';
            //currentGame['A', 'f'] = ' ';
            //currentGame['B', 'e'] = 'x';
            Console.WriteLine("{0}{0}after changes:{0}{0}",Environment.NewLine);

            currentGame.PrintBoardGame(); //  print board after changes 

            //Console.WriteLine(currentGame['H','e']);
            //Console.WriteLine(currentGame.m_BoardOfGame[7,4]);
            Console.ReadLine();


           // string te = "abcd";
           // te[2] = 'g';
           // te.ElementAt(2) = 'g';

           //char[] techar= te.ToCharArray();
           // techar[2] = 'g';


        }

        
        

    };


}
