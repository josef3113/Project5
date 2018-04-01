using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    class DamkaGame
    {
        public int m_SizeOfBoardGame;   // need to be private 
        public char[,] m_BoardOfGame;   // need to be private 
        public DamkaGame(int i_SizeOfBoard = 8)
        {
            m_SizeOfBoardGame = i_SizeOfBoard;
            m_BoardOfGame = CreatBoard();
        }
        // be private becouse users dont need to know about this method
        private char[,] CreatBoard()
        {
            char[,] boardOfGame = new char[m_SizeOfBoardGame, m_SizeOfBoardGame];
            bool rowEven = true;

            for (int i = 0; i < (m_SizeOfBoardGame - 2) / 2; i++)
            {
                for (int j = 0; j < m_SizeOfBoardGame; j += 2)
                {
                    if (rowEven)
                    {
                        boardOfGame[i, j + 1] = 'o';
                        boardOfGame[(m_SizeOfBoardGame - 1) - i, j] = 'x';
                    }
                    else
                    {
                        boardOfGame[i, j] = 'o';
                        boardOfGame[(m_SizeOfBoardGame - 1) - i, j + 1] = 'x';
                    }
                }
                rowEven = !rowEven;
            }

            return boardOfGame;

        }
        // not be static becous is print Board of specific item !!
        public  void PrintBoardDamka()
        {
           // Ex02.ConsoleUtils.Screen.Clear();
            StringBuilder lineBuffer = new StringBuilder(5 * m_SizeOfBoardGame);
            lineBuffer.Append("==");
            for (int i = 0; i < m_SizeOfBoardGame; i++)
            {
                lineBuffer.Append("====");
            }

            char signRow = 'a', signCol = 'A';
            Console.Write(" ");
            for (int i = 0; i < m_SizeOfBoardGame; i++)
            {
                Console.Write("  " + signCol + " ");
                signCol++;
            }
            Console.WriteLine();
            for (int i = 0; i < m_SizeOfBoardGame; i++)
            {
                Console.Write("{0}{1}{2}", lineBuffer, Environment.NewLine, signRow);
                for (int j = 0; j < m_SizeOfBoardGame; j++)
                {
                    Console.Write("| " + m_BoardOfGame[i, j] + " ");
                }
                Console.WriteLine("|");
                signRow++;

            }

        }

        //activ
        public bool Active()
        {   // must be one exit point //fix that//
            bool doneActive = false;
            string active;
            while ( ! doneActive)
            {
                active = Console.ReadLine();
                if (IsLegalActive(active))
                {
                    this[active[3], active[4]] = this[active[0], active[1]];
                    this[active[0], active[1]] = ' ';
                    doneActive = true;
                }
                else
                {
                    Console.WriteLine("wrong activity try another");
                }

            }
            
            return doneActive;
        }

        // todo
        // add check that activity in board and that in formt like Af>Be
        // need to add mhethot that checking that activity is string of letter uper and lower 
        public bool IsLegalActive(string i_Active)
        {
            bool answer = false;
            if(i_Active[2] == '>')
            {
                // i assmes that string its uper/lower leeter 
                if ( i_Active[0] - 'A' < m_SizeOfBoardGame && i_Active[1] - 'a' < m_SizeOfBoardGame)
                {
                    if (i_Active[3] - 'A' < m_SizeOfBoardGame && i_Active[4] - 'a' < m_SizeOfBoardGame)
                    {
                        answer = true;
                    }
                }
            }
            
            return answer;
        }


        // indexr that do A,f like 1,6
        public char this[char i_Row, char i_Col]  // think about this !!
        {
            get
            {
                return m_BoardOfGame[i_Col - 'a', i_Row - 'A'];
            }
            set
            {
                m_BoardOfGame[i_Col - 'a', i_Row - 'A'] = value;
            }
        }

    }
}
