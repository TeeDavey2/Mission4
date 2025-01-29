using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4
{
    internal class Methods
    {
        public void DisplayBoard(string[] gameBoard)
        {
            Console.Write($" {gameBoard[0]} |");
            Console.Write($" {gameBoard[1]} |");
            Console.Write($" {gameBoard[2]} \n");

            Console.WriteLine("-----------");

            Console.Write($" {gameBoard[3]} |");
            Console.Write($" {gameBoard[4]} |");
            Console.Write($" {gameBoard[5]} \n");

            Console.WriteLine("-----------");

            Console.Write($" {gameBoard[6]} |");
            Console.Write($" {gameBoard[7]} |");
            Console.Write($" {gameBoard[8]} ");
        }

        public bool ValidateGuess(string guess, string[] gameBoard)
        {
            bool result = true;
            if (guess.Length != 1 | Char.IsLetter(guess[0]) | guess[0] <= 0)
            {
                Console.WriteLine("Sorry, the guess must be between a number 1-9. Try again!");
                result = false;
            }

            else if (!gameBoard.Contains(guess))
            {
                Console.WriteLine("This number has already been taken. Try again!");
                result = false;
            }
            return result;
        }
    }
}
