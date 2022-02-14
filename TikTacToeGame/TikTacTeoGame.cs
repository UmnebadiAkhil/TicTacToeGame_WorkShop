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

        /// UC2
        // Choices this instance.

        public char Choice()
        {
            Console.WriteLine("Enter your choice. \n X \n 0");
            char userSign = Convert.ToChar(Console.ReadLine());
            string choice;
            switch (userSign)
            {
                case 'X':
                    choice = "You Chose: X";
                    break;
                case '0':
                    choice = "You Chose: 0";
                    break;
                default:
                    choice = "Invalid Choice";
                    break;
            }
            Console.WriteLine(choice);
            if (choice == "Invalid Choice")
                Choice();
            return userSign;
        }

    }
}