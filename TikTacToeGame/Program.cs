using System;
using TikTacToeGame;

namespace Tic_Tac_Toe_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Tic-Tac-Toe Game problem statement!");

            TicTacToeGame game = new TicTacToeGame();
            //game.CreateBoard();

            game.Choice();
        }
    }
}