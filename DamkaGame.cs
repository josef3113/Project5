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
        public DamkaGame(int i_SizeOfBoard)
        {
            m_BoardOfGame = CreatBoard(i_SizeOfBoard);
            m_SizeOfBoardGame = i_SizeOfBoard;
        }
        // be private becouse users dont need to know about this method
        private char[,] CreatBoard(int i_Size = 3)
        {
            char[,] boardOfGame = new char[i_Size, i_Size];
            bool rowEven = true;

            for (int i = 0; i < (i_Size - 2) / 2; i++)
            {
                for (int j = 0; j < i_Size; j += 2)
                {
                    if (rowEven)
                    {
                        boardOfGame[i, j + 1] = 'o';
                        boardOfGame[(i_Size - 1) - i, j] = 'x';
                    }
                    else
                    {
                        boardOfGame[i, j] = 'o';
                        boardOfGame[(i_Size - 1) - i, j + 1] = 'x';
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

        // indexr that do A,f like 1,6
        public char this[char i_Row, char i_Col]
        {
            get
            {
                return m_BoardOfGame[ i_Col - 'a', i_Row - 'A'];
            }
            set
            {
                m_BoardOfGame[ i_Col - 'a', i_Row - 'A'] = value;
            }
        }
    }
}
