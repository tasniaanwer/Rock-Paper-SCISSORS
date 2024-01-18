using REFACTORED_ROCK_PAPER;
using System;

namespace MyFirstProgram
{
    

    
    

    class Program
    {
        static void Main(string[] args)
        {
            IGame rockPaperScissorsGame = new RockPaperScissorsGame();
            rockPaperScissorsGame.Play();

            IGame ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.Play();
        }
    }
}
