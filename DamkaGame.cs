using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// to add function of move 
// and beking 
// and erase 
namespace Project5
{
    class BordToGame
    {
        
        public int m_SizeOfBoardGame;   // need to be private 
        public char[][] m_BoardOfGame;   // need to be private 
        public BordToGame(int i_SizeOfBoard = 8)
        {
            m_SizeOfBoardGame = i_SizeOfBoard;
            m_BoardOfGame = CreatBoard();
        }
        // be private becouse users dont need to know about this method
        private char[][] CreatBoard()
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


            StringBuilder lineBuffer = new StringBuilder(5 * m_SizeOfBoardGame);
            lineBuffer.Append("==");
            for (int i = 0; i < m_SizeOfBoardGame; i++)
            {
                lineBuffer.Append("====");
            }


            char[][] stringBaord = new char[2 * m_SizeOfBoardGame + 2][];

            StringBuilder colSign = new StringBuilder();
            char signRow = 'a', signCol = 'A';
            colSign.Append(' ');
            for (int i = 0; i < m_SizeOfBoardGame; i++)
            {
                colSign.Append("  " + signCol + " ");
                signCol++;
            }
            stringBaord[0] = colSign.ToString().ToCharArray();
            StringBuilder linesOfBoard = new StringBuilder();
            for (int i = 1; i < 2 * m_SizeOfBoardGame + 2; i += 2)
            {
                stringBaord[i] = lineBuffer.ToString().ToCharArray();    // check this 
            }

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
                stringBaord[currentLine] = linesOfBoard.ToString().ToCharArray();
                currentLine += 2;
                signRow++;
            }


            return stringBaord;

        }
        // not be static becous is print Board of specific item !!
        public  void PrintBoardGame()
        {
           // Ex02.ConsoleUtils.Screen.Clear();
            for (int i = 0; i < 2*m_SizeOfBoardGame +2 ; i ++)
            {
                Console.WriteLine(m_BoardOfGame[i]);

            }

        }

       
        //activ
        public bool Active()
        {   // must be one exit point //fix that//
            bool doneActive = false;
            string active;
            while (!doneActive)
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
            if (i_Active[2] == '>')
            {
                // i assmes that string its uper/lower leeter 
                if (i_Active[0] - 'A' < m_SizeOfBoardGame && i_Active[1] - 'a' < m_SizeOfBoardGame)
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
        public char this[char i_Col, char i_Row]  // think about this !!
        {
            get
            {
                //todo
                return m_BoardOfGame[(2*(i_Row - 'a' )+ 2)][(4*(i_Col-'A') + 3)];
            }
            set
            {
                 m_BoardOfGame[(2 *( i_Row - 'a') + 2) ][(4 * (i_Col - 'A') + 3) ] = value;
            }
        }

    }
}












//nothing

//public char [,] CreatMatrixBoard()
//{
//    char[,] matrixOfBoard= new char[m_SizeOfBoardGame, m_SizeOfBoardGame];

//    StringBuilder lineBuffer = new StringBuilder(5 * m_SizeOfBoardGame);
//    lineBuffer.Append("==");
//    for (int i = 0; i < m_SizeOfBoardGame; i++)
//    {
//        lineBuffer.Append("====");
//    }
//    int iColMatrix = 0;
//    int iRowMatrix = 0;
//    char signRow = 'a', signCol = 'A';

//    //Console.Write(" ");
//    matrixOfBoard[iColMatrix, iRowMatrix] = ' ';
//    //for (int i = 0; i < m_SizeOfBoardGame; i++)
//    for(;iRowMatrix < m_SizeOfBoardGame; iRowMatrix++)
//    {
//        //Console.Write("  " + signCol + " ");
//        matrixOfBoard[iColMatrix, iRowMatrix++] = ' ';
//        matrixOfBoard[iColMatrix, iRowMatrix++] = signCol;
//        matrixOfBoard[iColMatrix, iRowMatrix] = ' ';
//     signCol++;
//    }
//    //Console.WriteLine();
//    iColMatrix++;
//    iRowMatrix = 0; 

//    for (int i = 0; i < m_SizeOfBoardGame; i++)
//    {
//        //Console.Write("{0}{1}{2}", lineBuffer, Environment.NewLine, signRow);
//        matrixOfBoard[iColMatrix, iRowMatrix++] = '=';
//        matrixOfBoard[iColMatrix, iRowMatrix++] = '=';
//        for (; iRowMatrix < m_SizeOfBoardGame;)
//        {
//            //lineBuffer.Append("====");
//            matrixOfBoard[iColMatrix, iRowMatrix++] = '=';
//            matrixOfBoard[iColMatrix, iRowMatrix++] = '=';
//            matrixOfBoard[iColMatrix, iRowMatrix++] = '=';
//            matrixOfBoard[iColMatrix, iRowMatrix++] = '=';
//        }
//        // for (int j = 0; j < m_SizeOfBoardGame; j++)


//        for (; iRowMatrix < m_SizeOfBoardGame;)
//        {
//            iColMatrix++;
//            matrixOfBoard[iColMatrix, iRowMatrix++] = signRow;
//            matrixOfBoard[iColMatrix, iRowMatrix++] = '|';
//            matrixOfBoard[iColMatrix, iRowMatrix++] = ' ';
//            matrixOfBoard[iColMatrix, iRowMatrix++] = m_BoardOfGame[i, j]

//            Console.Write("| " + m_BoardOfGame[i, j] + " ");
//        }
//        Console.WriteLine("|");
//        signRow++;

//    }



//}
