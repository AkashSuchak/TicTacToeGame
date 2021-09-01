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
    }
}
