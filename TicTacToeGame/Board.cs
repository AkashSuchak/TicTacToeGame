using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    class Board
    {
        //Constructor
        public Board()
        {
            char[] board = InitializeBoard();
            char[] symbol = UserSymbol();            
        }

        //Intializing Board with Empty Value
        public char[] InitializeBoard()
        {
            //Char Array of 10 elements
            char[] board = new char[10];

            //Assigning Space : Index 1 to 9
            for (int index = 1; index < board.Length; index++)
            {
                board[index] = ' ';
            }
            return board;
        }

        //Input taking from user X or O
        public static char[] UserSymbol()
        {
            char[] userSymbol = new char[2];            

            //Taking Symbol 'x' or 'y'
            while (true)
            {
                //Display Message
                Console.WriteLine("Choose a Letter X or O : ");

                //Inut User
                char userInput = Convert.ToChar(Console.ReadLine());

                //Assigning character to User and Computer as per input
                if (userInput == 'X')
                {
                    userSymbol[0] = 'X';
                    userSymbol[1] = 'O';
                    return userSymbol;
                }
                else if (userInput == 'O')
                {
                    userSymbol[0] = 'O';
                    userSymbol[1] = 'X';
                    return userSymbol;
                }
                else Console.WriteLine("Wrong Input!!! Try Again");
            }
        }

       
    }
}
