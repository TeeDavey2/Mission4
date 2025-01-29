namespace Mission4;

using System.ComponentModel.DataAnnotations;

internal class Program
{
    internal static void Main(string[] args)
    {
        Methods m = new Methods();

        string[] gameBoard = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        var gameResult = (true , "");
        string position;

        Console.WriteLine("Welcome to the Tic-Tac-Toe Game!\n");

        do
        {
            m.DisplayBoard(gameBoard);

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

            gameResult = m.GameOver(gameBoard);

        } while (!gameResult.Item1);

        Console.WriteLine(DisplayWinner());

        string DisplayWinner()
        {
            return ($"Congragulations {gameResult.Item2}. You Won!");
        }
    }
}



