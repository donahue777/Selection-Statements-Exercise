namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try to guess the correct number.");
            Console.WriteLine("Input the upper limit for the range of the number.");

            var userResponse = Console.ReadLine();
            var upperLimit = int.Parse(userResponse);

            var random = new Random();
            var number = random.Next(1, upperLimit);

            Console.WriteLine("Input your guess.");

            var guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Your number is too high.");
            }

            else if (guess < number)
            {
                Console.WriteLine("Your number is too low.");
            }

            else     
            {
                Console.WriteLine("Congrats!! You've guessed the correct number!");
            }
        }
    }
}
