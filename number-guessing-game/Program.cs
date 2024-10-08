namespace number_guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lives = 3;

            Console.WriteLine($"Hello World! Welcome to my number guessing game! You have {lives} lives, guess before you run out!");

            Console.WriteLine("Please enter the maximum random number:");

            string inputMaximumRandomNumber = Console.ReadLine();

            int convertMaximumRandomNumber = int.Parse(inputMaximumRandomNumber);

            Random number = new Random();

            int randomNumber = number.Next(convertMaximumRandomNumber);

            Console.WriteLine("Please enter a random number:");

            while (lives > 0)
            {
                string userInput = Console.ReadLine();

                int convertUserInputToNumber = int.Parse(userInput);

                if (convertUserInputToNumber == randomNumber)
                {
                    Console.WriteLine("Well done! You guessed the number.");
                    
                    break;
                }
                else if (convertUserInputToNumber != randomNumber)
                {
                    Console.WriteLine("Incorrect! Please try again!");
                    
                    Console.WriteLine($"You have {lives} lives left.");            
                    
                    lives--;

                    if (convertUserInputToNumber < randomNumber)
                    {
                        Console.WriteLine("Hint: Your guess is less than the random number.");

                        Console.WriteLine("\nPlease enter another random number:");
                    } 
                    else if (convertUserInputToNumber > randomNumber)
                    {
                        Console.WriteLine("Hint: Your guess is more than the random number.");

                        Console.WriteLine("\nPlease enter another random number:");
                    }
                }
            }

            if (lives == 0)
            {
                Console.WriteLine("Sorry! You ran out of lives! You lose!");
            }
        }
    }
}
