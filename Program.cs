// Christian Christensen, Trevor Davis, Carson Tanner, Brandon Fromm
// Section 3
// Group 9
// Mission 4 Tic-Tac-Toe
namespace Mission4;

internal class Program
{
    internal static void Main(string[] args)
    {
        // Initialize Methods class and variables
        Methods m = new Methods();

        string[] gameBoard = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        var gameResult = (true , "");
        string position;
        
        // welcomes user to the game
        Console.WriteLine("Welcome to the Tic-Tac-Toe Game!\n");
        
        // loops until one of the players gets one of the winning combinations
        do
        {
            m.DisplayBoard(gameBoard);
            
            // gets the players inputs, makes sure they are valid, and updates game board array with move
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
            
            // Check if a player has won
            gameResult = m.GameOver(gameBoard);

        } while (!gameResult.Item1);

        Console.WriteLine(DisplayWinner());
        // displays who the winner is
        string DisplayWinner()
        {
            return ($"Congragulations {gameResult.Item2}. You Won!");
        }
    }
}



