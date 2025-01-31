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
            //Keeping track of turns
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
                (gameBoard, turnNum) = m.PlayerTurn(gameBoard, 1, turnNum);
                m.DisplayBoard(gameBoard);

                //Checking for wins or ties
                gameResult = m.GameOver(gameBoard, turnNum);
                if (gameResult == 1 | gameResult == 3)
                {
                    break;
                }

                //Player 2 Turn
                (gameBoard, turnNum) = m.PlayerTurn(gameBoard, 2, turnNum);
                m.DisplayBoard(gameBoard);


                // checks if a player has won
                gameResult = m.GameOver(gameBoard, turnNum);
            } while (gameResult == 0);

            Console.WriteLine(m.DisplayWinner(gameResult));

            //Play again logic
            bool playAgain = m.PlayAgain();
            if (!playAgain)
            {
                Console.WriteLine("Thanks for playing! Goodbye!");
                break;
            }
        }
    }
}