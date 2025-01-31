// Trevor Davis, Christian Christensen, Carson Tanner, and Brandon Fromm
// Section 3
// Group 9
// Mission 4 Tic-Tac-Toe
namespace Mission4;

internal class Program
{
    internal static void Main(string[] args)
    {
        // initializes method class and other variables
        Methods m = new Methods();

        while (true)
        {
            string[] gameBoard = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int gameResult;
            string position;
            int turnNum = 0;

            // welcome to the program
            Console.WriteLine("Welcome to the Tic-Tac-Toe Game!");
            Console.WriteLine("To select a spot, enter the number in the box to replace it with your letter!\n");

            // Displays board immediately
            m.DisplayBoard(gameBoard);

            // loops through the game until a player has won the game
            do
            {
                // Player 1 Turn
                //Incrementing turn
                turnNum++;
                // Gets player inputs, makes sure they are valid, and updates the board game array for each guess
                do
                {
                    Console.WriteLine($"\nTurn {turnNum}: Player 1");
                    position = Console.ReadLine();

                } while (!m.ValidateGuess(position, gameBoard));

                // Updating gameboard
                gameBoard[int.Parse(position) - 1] = "X";
                m.DisplayBoard(gameBoard);

                //Checking for wins or ties
                gameResult = m.GameOver(gameBoard, turnNum);
                if (gameResult == 1 | gameResult == 3)
                {
                    break;
                }

                //Player 2 Turn
                //Incrementing turn
                turnNum++;
                // Gets player inputs, makes sure they are valid, and updates the board game array for each guess
                do
                {
                    Console.WriteLine($"\nTurn {turnNum}: Player 2");
                    position = Console.ReadLine();

                } while (!m.ValidateGuess(position, gameBoard));

                // Updating gameboard
                gameBoard[int.Parse(position) - 1] = "O";
                m.DisplayBoard(gameBoard);


                // checks if a player has won
                gameResult = m.GameOver(gameBoard, turnNum);
            } while (gameResult == 0);

            //Displays the winner/loser or tie
            Console.WriteLine(m.DisplayWinner(gameResult));

            //Option to play again 
            bool playAgain = m.PlayAgain();
            if (!playAgain)
            {
                Console.WriteLine("Thanks for playing! Goodbye!");
                break;
            }
            //Adding an extra line for aesthetic purposes
            Console.WriteLine();
        }
    }
}