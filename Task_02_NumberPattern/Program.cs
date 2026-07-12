namespace Task_02_NumberPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number of Rows: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            while (true)
            {
                Console.WriteLine("\n===== Number Pattern Generator =====");
                Console.WriteLine("1. Increasing Number Pattern");
                Console.WriteLine("2. Repeating Number Pattern");
                Console.WriteLine("3. Floyd's Triangle");
                Console.WriteLine("4. Number Pyramid");
                Console.WriteLine("5. Exit");

                Console.Write("\nEnter Your Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        IncreasingPattern(n);
                        break;

                    case 2:
                        RepeatingPattern(n);
                        break;

                    case 3:
                        FloydTriangle(n);
                        break;

                    case 4:
                        NumberPyramid(n);
                        break;

                    case 5:
                        Console.WriteLine("Thank You!");
                        return;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
        }

        static void IncreasingPattern(int n)
        {
            Console.WriteLine("Increasing Number Pattern\n");

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        static void RepeatingPattern(int n)
        {
            Console.WriteLine("Repeating Number Pattern\n");

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }

        static void FloydTriangle(int n)
        {
            Console.WriteLine("Floyd's Triangle\n");

            int num = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }
        }

        static void NumberPyramid(int n)
        {
            Console.WriteLine("Number Pyramid\n");

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                for (int j = i - 1; j >= 1; j--)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }
        }
    }
}