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
            DamkaGame currentGame = new DamkaGame(8);
            currentGame.PrintBoardDamka();
            currentGame['G', 'f'] = ' ';   // player move white alfabetic sign
            currentGame['H', 'e'] = 'x';
            Console.WriteLine("{0}{0}after changes:{0}{0}",Environment.NewLine);

            currentGame.PrintBoardDamka(); // print board after changes 

            //Console.WriteLine(currentGame['H','e']);
            //Console.WriteLine(currentGame.m_BoardOfGame[7,4]);



        }

        
        

    };


}
