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

        string[] gameBoard = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        int gameResult;
        string position;

        // welcome to the program
        Console.WriteLine("Welcome to the Tic-Tac-Toe Game!\n");

        //Keeping track of turns
        int turnNum = 0;

        // loops through the game until a player has won the game
        do
        {
            turnNum++;
            Console.WriteLine($"\nTurn: {turnNum}");

            m.DisplayBoard(gameBoard);

            // gets player inputs, makes sure they are valid, and updates the board game array for each guess
            // Player 1:
            //Increase turn number

            do
            {
                Console.WriteLine("\nPlayer 1 - Type the number of a tile to play: ");
                position = Console.ReadLine();

            } while (!m.ValidateGuess(position, gameBoard));

            gameBoard[int.Parse(position) - 1] = "X";

            m.DisplayBoard(gameBoard);


            //Checking if the game is over
            gameResult = m.GameOver(gameBoard, turnNum);
            if (gameResult == 1 | gameResult == 3)
            {
                break;
            }

            //Player 2
            //Increase turn number
            turnNum++;
            Console.WriteLine($"\nTurn: {turnNum}");

            do
            {
                Console.WriteLine("\nPlayer 2 - Type the number of a tile to play: ");
                position = Console.ReadLine();

            } while (!m.ValidateGuess(position, gameBoard));

            // Replacing number with 'O'
            gameBoard[int.Parse(position) - 1] = "O";

            // checks if a player has won
            gameResult = m.GameOver(gameBoard, turnNum);
        } while (gameResult == 0);

        Console.WriteLine(m.DisplayWinner(gameResult));
    }
}



