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

        // loops through the game until a player has won the game
        do
        {
            m.DisplayBoard(gameBoard);
            
            // gets player inputs, makes sure they are valid, and updates the board game array for each guess
            do
            {
                Console.WriteLine("Player 1 Please enter a number below to mark a position on the game board: ");
                position = Console.ReadLine();

            } while (!m.ValidateGuess(position, gameBoard));

            gameBoard[int.Parse(position) - 1] = "X";

            m.DisplayBoard(gameBoard);

            do
            {
                Console.WriteLine("\nPlayer 2 Please enter a number below to mark a position on the game board: ");
                position = Console.ReadLine();

            } while (!m.ValidateGuess(position, gameBoard));

            gameBoard[int.Parse(position) - 1] = "O";
            
            // checks if a player has won
            gameResult = m.GameOver(gameBoard);

        } while (gameResult == 0);

        Console.WriteLine(DisplayWinner());
        // prints out who won the game
        string DisplayWinner()
        {
            return ($"Congragulations Player {gameResult}. You Won!");
        }
    }
}



