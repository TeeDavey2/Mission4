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

        //TURN METHOD
        public (string[], int) PlayerTurn(string[] gameBoard, int playerNumber, int turnNum)
        {
            string displayLetter = "";
            string position = "";
            //Incrementing turnNum
            turnNum++;

            //Determining 'X' or 'O'
            if (playerNumber == 1)
            {
                displayLetter = "X";
            }
            else if (playerNumber == 2)
            {
                displayLetter = "O";
            }

            //Turn 
            // Gets player inputs, makes sure they are valid, and updates the board game array for each guess

            do
            {
                Console.WriteLine($"\nTurn {turnNum}: Player {playerNumber}");
                position = Console.ReadLine();

            } while (!ValidateGuess(position, gameBoard));

            gameBoard[int.Parse(position) - 1] = displayLetter;

            return (gameBoard, turnNum);
        }

        public int GameOver(string[] gameBoard, int turnNum)
        {
            // Winning combinations
            //Horizontal 012, 345, 678
            //Vertical 036, 147, 258
            //Diagonal 048, 642
            string[] winningCombinations = new string[8] { "012", "345", "678", "036", "147", "258", "048", "642" };

            int gameResult = 0;

            if (turnNum < 9)
            {
                for (int i = 0; i < winningCombinations.Length; i++)//Going through every winning combination
                {
                    string testString = "";
                    string combo = winningCombinations[i];

                    for (int x = 0; x < 3; x++)
                    {
                        // Convert the character combo[x] to an integer index and access gameBoard
                        int index = combo[x] - '0'; // Convert '0' -> 0, '1' -> 1, etc.
                        testString += gameBoard[index];

                        if (testString == "XXX")
                        {
                            gameResult = 1;
                        }
                        else if (testString == "OOO")
                        {
                            gameResult = 2;
                        }
                    }
                }
            }
            else if (turnNum == 9)
            {
                gameResult = 3;
            }
            return gameResult;
        }

        public string DisplayWinner(int gameResult)
        {
            string winnerString = "";
            if (gameResult == 1 | gameResult == 2)
            {
                winnerString = $"\nCongratulations Player {gameResult}. You Won!";
            }
            else if (gameResult == 3)
            {
                winnerString = $"\nIt's a tie!";
            }
            return winnerString;
        }

        public bool PlayAgain()
        {
            bool play = false;
            string response = "";
            Console.WriteLine("Would you like to play again? (Y/N)");
            do
            {
                response = Console.ReadLine().ToUpper(); // Normalize input to uppercase

                if (response == "Y")
                {
                    play = true;
                }
                else if (response == "N")
                {
                    play = false;
                }
                else
                {
                    Console.WriteLine("Please enter a valid response (Y/N).");
                }
            }
            while (response != "Y" && response != "N"); // Corrected condition

            return play;
        }
    }
}
