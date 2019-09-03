/*
 * Author: Christian Edge
 * Course: CIS 216 C# and .NET
 * Date: 02 APR 2019
 * Nim Project
 */

 /* The purpose of this code is to run the game Nim.
  * Nim is a very old game with many versions. In this version there will be one 
  * pile of 22 sticks and two players: a human, and a computer-controlled AI player.
  * Each player will pick up between 1 and 4 sticks. The player to pick up the last
  * stick is the winner. The game alternates between players. A message is diplayed
  * to declare the winner, then the game closes.
  */


using System;

class Nim
{
    //Declare variables and methods

    //These booleans will help keep track of whose turn it is
    private static bool humanPlayer, currentPlayer;

    //This method will determine if the game is over
    private static void isGameOver(int nimSticks, bool currentPlayer)
    {
        if (nimSticks == 0)
        {
            Console.WriteLine(GameOverOutput(currentPlayer));
            Environment.Exit(0);
        }
    }

    //This method returns a string that declares the game winner
    private static string GameOverOutput(bool currentPlayer)
    {
        string s = currentPlayer ? "Congratulations! You've won." : "I beat you! " +
            "Please play again.";
        return s;
    }

    static void Main()
    {
        //Assign values
        humanPlayer = true;
        currentPlayer = humanPlayer;
        //Declare Nim sticks pile amount
        int nimSticks = 22;

        //instantiate random object for AI
        Random random = new Random();

        //output welcome, instructions, and game start to user
        Console.WriteLine("Welcome to NIM");
        Console.WriteLine("Nim is a very old game with many versions. In this " +
            "version there will be one pile of 22 sticks and two players: a human " +
            "player, and a computer-controlled AI player. Each player will pick " +
            "up between 1 and 4 sticks.\n" +
            "The player to pick up the last stick is the winner.\n");
        Console.WriteLine("The game has begun. You will go first.");


        //Start game loop
        while (nimSticks > 0)
        {
            //Output nimSticks value
            Console.WriteLine($"There are {nimSticks} Nim sticks remaining in the pile.");

            /* We will alternate between players with an if...else statement.
             * Line 104 starts the else statement which is the AI's turn. */
            if (currentPlayer == humanPlayer) //Do the human player's move
            {
                bool ValidHumanMove = false;
                int currentMove = 0;
                
                do
                {
                    Console.WriteLine("How many sticks would you like to take? (1-4)");

                    ValidHumanMove = int.TryParse(Console.ReadLine(), out int number);

                    Console.WriteLine($"You input {number} sticks.");

                    if (number > 4 || number < 1 || number > nimSticks)
                    {
                        Console.WriteLine($"Your input was not between 1 and 4, " +
                            "or higher than the number of Nim sticks remaining. Please choose again.\n");
                        Console.WriteLine($"There are {nimSticks} Nim sticks remaining in the pile.");
                        ValidHumanMove = false; //Must set to false because TryParse will set it to true
                    }
                    else
                    {
                        currentMove = number;
                    }
                } while (!ValidHumanMove);

                //Subtract player move from Nim Sticks total
                nimSticks -= currentMove;
            }//End of human move

            //Computer-controlled player move
            else 
            {
                int currentMove = nimSticks > 4 ? random.Next(1, 4) : nimSticks;
                Console.WriteLine($"I choose {currentMove} sticks.");

                //Remove AI sticks from pile
                nimSticks -= currentMove;
            }//End of AI move

            //Check for Game Over
            isGameOver(nimSticks, currentPlayer);

            //Game still running, switch players
            currentPlayer = !currentPlayer;

        }//End of game 'while' loop
    }//End of Main()
}//End of class Nim

