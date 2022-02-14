using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTacToeGame
{
    class TicTacToeGame
    {
        public char[] board;
        public enum Player { USER, COMPUTER };


        // Initializes a new instance 

        public TicTacToeGame()
        {
            board = new char[10];
        }

        // UC1
        // Creates the board.

        public void CreateBoard()
        {
            for (int position = 1; position < 10; position++)
            {
                board[position] = ' ';
            }
        }
    }
}