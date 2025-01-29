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
            if (guess.Length != 1 | Char.IsLetter(guess[0]) | guess[0] <= 0) // Checking if the guess is 1 character, a number, and more than 0
            {
                Console.WriteLine("Sorry, the guess must be between a number 1-9. Try again!");
                result = false;
            }

            else if (!gameBoard.Contains(guess)) // Checking if spot has already been taken
            {
                Console.WriteLine("This number has already been taken. Try again!");
                result = false;
            }
            return result;
        }

        public Tuple GameOver(string[] gameBoard)
        {
            // Winning combinations
            //Horizontal 012, 345, 678
            //Vertical 036, 147, 258
            //Diagonal 048, 642
            string[] winningCombinations = new string[8] {"012","345","678","036", "147", "258", "048", "642" };

            //return if the game is over and the team that won (Team 1 = X, Team 2 = O)


            for (int i = 0; i < winningCombinations.Length; i++)//Going through every winning combination
            {
                string testString = "";
                

                for (int x = 0; x < 3; x++)
                {
                    testString += gameBoard[i];
                    if (testString.Length == 3)
                    {
                        if (testString == "XXX")
                        {
                            
                        }
                        else if (testString == "OOO")
                        {
                            
                        }
                    }
                }
            }
            return gameResults;
        }
    }
}
