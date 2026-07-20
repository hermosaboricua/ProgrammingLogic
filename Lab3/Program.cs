namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Problem 1:");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\nProblem 2:");

        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}