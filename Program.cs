
using System.ComponentModel.DataAnnotations;

Method m = new Method();

string[] gameBoard = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
Tuple gameResult;
int position;

Console.WriteLine("Welcome to the Tic-Tac-Toe Game!\n");

do
{
    m.DisplayBoard(gameBoard);

    Console.WriteLine("Player 1 Please enter a number below to mark a position on the game board: ");
    position = int.Parse(Console.ReadLine());

    gameBoard[position - 1] = "X";

    m.DisplayBoard(gameBoard);

    Console.WriteLine("\nPlayer 2 Please enter a number below to mark a position on the game board: ");
    position = int.Parse(Console.ReadLine());

    gameBoard[position - 1] = "O";

    gameResult = gameOver(gameBoard);

} while (!gameResult.Item1);

DisplayWinner();

string DisplayWinner()
{
    return Console.WriteLine($"Congragulations {gameResult.Item2}. You Won!");
}

