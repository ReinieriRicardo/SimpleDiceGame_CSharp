namespace SimpleDiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            int IAInput;
            int userScore = 0;
            int IAScore = 0;

            while (true)
            {
                Console.WriteLine("Press any key to roll the dice");
                Console.ReadLine();
                Random random = new Random();
                userInput = random.Next(1, 7);
                IAInput = random.Next(1, 7);
                Console.WriteLine($"You rolled a {userInput}");
                Console.WriteLine("...");
                Console.WriteLine($"Enemy IA rolled a {IAInput}");

                if (userInput > IAInput)
                {
                    userScore++;
                    Console.WriteLine("You win this round!");
                }
                else if (userInput < IAInput)
                {
                    IAScore++;
                    Console.WriteLine("Enemy IA wins this round!");
                }
                else
                {
                    Console.WriteLine("It's a tie!");
                }

                Console.WriteLine($"The score is now - Player: {userScore} .Enemy: {IAScore} \n");

            }
        }
    }
}
