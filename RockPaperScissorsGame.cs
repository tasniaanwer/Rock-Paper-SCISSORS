using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REFACTORED_ROCK_PAPER
{
    class RockPaperScissorsGame : IGame
    {
        private readonly Random random = new Random();

        public void Play()
        {
            bool playAgain = true;

            while (playAgain)
            {
                string player = GetPlayerChoice();

                string computer = GetComputerChoice();

                DisplayChoices(player, computer);

                DetermineWinner(player, computer);

                playAgain = AskToPlayAgain();
            }

            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();
        }

        private string GetPlayerChoice()
        {
            string player = "";
            while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
            {
                Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
                player = Console.ReadLine()?.ToUpper();
            }
            return player;
        }

        private string GetComputerChoice()
        {
            switch (random.Next(1, 4))
            {
                case 1:
                    return "ROCK";
                case 2:
                    return "PAPER";
                case 3:
                    return "SCISSORS";
                default:
                    return "";
            }
        }

        private void DisplayChoices(string player, string computer)
        {
            Console.WriteLine($"Player: {player}");
            Console.WriteLine($"Computer: {computer}");
        }

        private void DetermineWinner(string player, string computer)
        {
            if (IsPlayerWin(player, computer))
            {
                Console.WriteLine("You win!");
            }
            else if (IsPlayerWin(computer, player))
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
        }

        private bool IsPlayerWin(string firstChoice, string secondChoice)
        {
            return (firstChoice == "ROCK" && secondChoice == "SCISSORS") ||
                   (firstChoice == "PAPER" && secondChoice == "ROCK") ||
                   (firstChoice == "SCISSORS" && secondChoice == "PAPER");
        }

        private bool AskToPlayAgain()
        {
            Console.Write("Would you like to play again (Y/N): ");
            string answer = Console.ReadLine()?.ToUpper();
            return answer == "Y";
        }
    }

}
