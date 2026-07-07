namespace Task01_TextGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NUMBER GUESSING GAME");
            Console.WriteLine("Choose a number between 1 and 100");
            Console.WriteLine();

            Random random = new Random();

            int secrateNum = random.Next(1, 101);
            int atteptCount = 0;

            while (true)
            {
                Console.Write("Choose a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                atteptCount++;

                if (number > secrateNum)
                {
                    Console.WriteLine("Your chosen number is too high...");
                }
                else if (number < secrateNum)
                {
                    Console.WriteLine("Your chosen number is too low...");
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed the correct number.");
                    Console.WriteLine($"You guessed the number in {atteptCount} attempts.");
                    break;
                }
            }
        }
    }
}