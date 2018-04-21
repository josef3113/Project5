﻿//14/04/2018  15:00

using System;
using System.Collections.Generic;
using System.Text;

namespace Project5
{
    class BordToGame
    {
        public int m_SizeOfBoardGame;   // need to be private  readonly

        public char[,] m_BoardOfGame;   // need to be private 

        public BordToGame(int i_SizeOfBoard = 8)

        {

            m_SizeOfBoardGame = i_SizeOfBoard;

            m_BoardOfGame = CreatBoard();

        }

        // be private becouse users dont need to know about this method
        public void ResetBoardOfGame()
        {
            // chang this
            m_BoardOfGame = CreatBoard();
        }

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



            char[,] stringBaord = new char[2 * m_SizeOfBoardGame + 2, 4 * m_SizeOfBoardGame + 2];

            StringBuilder lineBuffer = new StringBuilder(5 * m_SizeOfBoardGame);

            lineBuffer.Append("==");

            for (int i = 0; i < m_SizeOfBoardGame; i++)

            {

                lineBuffer.Append("====");

            }



            StringBuilder rowOfSignColsUp = new StringBuilder();

            char signRow = 'a', signCol = 'A';

            rowOfSignColsUp.Append(' ');

            for (int i = 0; i < m_SizeOfBoardGame; i++)

            {

                rowOfSignColsUp.Append("  " + signCol + " ");

                signCol++;

            }


            // start
            for(int i=0; i< rowOfSignColsUp.Length;i++)
            {
                stringBaord[0,i] = rowOfSignColsUp[i];
            }
            
            //end

            //start
            for (int i = 1; i < 2 * m_SizeOfBoardGame + 2; i += 2 )

            {
                for (int j = 0; j < lineBuffer.Length; j++)
                {
                    stringBaord[i, j] = lineBuffer[j];
                }
                  

            }

            //end



            StringBuilder linesOfBoard = new StringBuilder();

            int currentLine = 2;

            for (int i = 0; i < m_SizeOfBoardGame; i++)

            {

                linesOfBoard.Clear();

                linesOfBoard.Append(signRow);

                for (int j = 0; j < m_SizeOfBoardGame; j++)

                {

                    linesOfBoard.Append("| " + boardOfGame[i, j] + " ");

                }

                linesOfBoard.Append("|");

                 
                //start
                for (int j = 0; j < linesOfBoard.Length; j++)
                {
                    stringBaord[currentLine, j] = linesOfBoard[j];
                }
                //end
                currentLine += 2;

                signRow++;

            }


            //for(int i=0;i< (2* m_SizeOfBoardGame +2); i++)
            //{
            //    for (int j = 0; j < lineBuffer.Length; j++)
            //    {
            //        Console.Write(stringBaord[i,j]);
            //    }
            //    Console.WriteLine();
            //}
            

            return stringBaord;



        }

        // not be static becous is print Board of specific item !!

        public void PrintBoardGame()

        {

            // Ex02.ConsoleUtils.Screen.Clear();

            for (int i = 0; i < (2 * m_SizeOfBoardGame + 2); i++)

            {
                for(int j =0; j< (2+ 4*m_SizeOfBoardGame); j++)
                {
                    Console.Write(m_BoardOfGame[i, j]);
                }

                Console.WriteLine();
            }
            


        }

        public void FlipToKing(string i_Locat)

        {

            this[i_Locat[0], i_Locat[1]] = (this[i_Locat[0], i_Locat[1]] == 'x') ? 'K' : 'U';

        }


        // indexr that acces to BoardToGame [Af]

        public char this[char i_Row, char i_Col]  // think about this !!

        {

            get

            {

                //todo

                return m_BoardOfGame[(2 * (i_Row - 'a') + 2),(4 * (i_Col - 'A') + 3)];

            }

            set

            {

                m_BoardOfGame[(2 * (i_Row - 'a') + 2),(4 * (i_Col - 'A') + 3)] = value;

            }

        }



    }
}
