using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;

            while (playAgain)
            {
                string player = GetPlayerChoice();

                string computer = GetComputerChoice(random);

                DisplayChoices(player, computer);

                DetermineWinner(player, computer);

                playAgain = AskToPlayAgain();
            }

            Console.WriteLine("Thanks for playing!");

            Console.ReadKey();
        }

        static string GetPlayerChoice()
        {
            string player = "";
            while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
            {
                Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
                player = Console.ReadLine();
                player = player.ToUpper();
            }
            return player;
        }

        static string GetComputerChoice(Random random)
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

        static void DisplayChoices(string player, string computer)
        {
            Console.WriteLine("Player: " + player);
            Console.WriteLine("Computer: " + computer);
        }

        static void DetermineWinner(string player, string computer)
        {
            if ((player == "ROCK" && computer == "PAPER") ||
                (player == "PAPER" && computer == "SCISSORS") ||
                (player == "SCISSORS" && computer == "ROCK"))
            {
                Console.WriteLine("You lose!");
            }
            else if ((player == "ROCK" && computer == "SCISSORS") ||
                     (player == "PAPER" && computer == "ROCK") ||
                     (player == "SCISSORS" && computer == "PAPER"))
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
        }

        static bool AskToPlayAgain()
        {
            Console.Write("Would you like to play again (Y/N): ");
            string answer = Console.ReadLine();
            return answer.ToUpper() == "Y";
        }
    }
}
