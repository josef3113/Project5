using System;
using System.Collections.Generic ;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    class Program
    {


        public static void Main()
        { 
            int size = 10;
            char[,] myBoard = CreatBoard(size);
            PrintBoardDamka(myBoard, size);

        }

        public static char[,] CreatBoard(int i_Size = 3)
        {
            char[,] boardOfGame = new char[i_Size, i_Size];
            bool rowEven = true;

            for (int i = 0; i < (i_Size - 2) / 2 ; i++)
            {
                for (int j = 0; j < i_Size; j += 2)
                {
                    if(rowEven)
                    {
                        boardOfGame[i, j + 1] = 'o';
                        boardOfGame[(i_Size - 1) - i, j] = 'x';
                    }
                    else
                    {
                        boardOfGame[i, j] = 'o';
                        boardOfGame[(i_Size - 1) - i, j+1] = 'x';
                    }  
                }
                rowEven = !rowEven;
            }

            return boardOfGame;

        }

        public static void PrintBoardDamka(char[,] i_BoardToPrint, int i_Size)
        {
            StringBuilder lineBuffer = new StringBuilder(5*i_Size);
            lineBuffer.Append("==");
            for (int i = 0; i < i_Size; i++)
            {
                lineBuffer.Append("====");
            }

            char signRow = 'a', signCol = 'A';
            Console.Write(" ");
            for (int i = 0; i < i_Size; i++)
            {
                Console.Write("  "+signCol+" ");
                signCol++;
            }
            Console.WriteLine();
            for (int i = 0; i < i_Size; i++)
            {
                Console.Write("{0}{1}{2}",lineBuffer, Environment.NewLine, signRow);
                for (int j = 0; j < i_Size; j++)
                {
                    Console.Write("| " + i_BoardToPrint[i, j]+ " ");
                }
                Console.WriteLine("|"); 
                signRow++;

            }  

        }

    };


}
