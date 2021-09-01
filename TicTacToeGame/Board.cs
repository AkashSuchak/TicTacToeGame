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
        public char[] UserSymbol()
        {
            char[] symbol = new char[2];            

            //Taking Symbol 'x' or 'o'
            while (true)
            {
                //Display Message
                Console.WriteLine("Choose a Letter X or O : ");

                //Inut User
                char userInput = Convert.ToChar(Console.ReadLine());
                
                //Assigning character to User and Computer as per input
                if (userInput == 'X')
                {
                    symbol[0] = 'X';
                    symbol[1] = 'O';
                    return symbol;
                }
                else if (userInput == 'O')
                {
                    symbol[0] = 'O';
                    symbol[1] = 'X';
                    return symbol;
                }
                else Console.WriteLine("Wrong Input!!! Try Again");
            }
        }
        // Displaying Board
        public void DisplayBoard()
        {
            char[] board = InitializeBoard();

            Console.WriteLine("-----------");
            Console.WriteLine(board[1] + " | " + board[2] + " | " + board[3]);
            Console.WriteLine("-----------");
            Console.WriteLine(board[4] + " | " + board[5] + " | " + board[6]);
            Console.WriteLine("-----------");
            Console.WriteLine(board[7] + " | " + board[8] + " | " + board[9]);
            Console.WriteLine("-----------");
        }        
    }
}
