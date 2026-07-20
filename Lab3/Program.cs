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

        Console.WriteLine("\nProblem 3:");

        int count = 5;

        while (count >= 1)
        {
            Console.WriteLine(count);
            count--;
        }

        Console.WriteLine("\nProblem 4:");

        int number = 10;

        while (number <= 1000)
        {
            Console.WriteLine(number);
            number += 10;
        }

        Console.WriteLine("\nProblem 5:");

        string[] seasons = { "Spring", "Summer", "Fall", "Winter" };

        foreach (string season in seasons)
        {
            Console.WriteLine(season);
        }

        Console.WriteLine("\nProblem 6:");

        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        Console.Write("Enter a number (1-7): ");
        int dayNumber = int.Parse(Console.ReadLine()!);

        if (dayNumber >= 1 && dayNumber <= 7)
        {
            Console.WriteLine("Day: " + days[dayNumber - 1]);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
        }

        Console.WriteLine("\nProblem 7:");

        string[] books =
        {
            "Harry Potter and the Sorcerer's Stone",
            "The Hunger Games",
            "The Hobbit"
        };

        string[] authors =
        {
            "J.K. Rowling",
            "Suzanne Collins",
            "J.R.R. Tolkien"
        };

        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine(books[i] + " by " + authors[i]);
        }

        Console.WriteLine("\nProblem 8:");

        int[] temperatures = { 72, 65, 80, 68, 75 };

        Array.Sort(temperatures);

        Console.WriteLine("Temperatures in ascending order:");

        foreach (int temp in temperatures)
        {
            Console.WriteLine(temp);
        }

        Console.WriteLine("Lowest temperature: " + temperatures[0]);
        Console.WriteLine("Highest temperature: " + temperatures[temperatures.Length - 1]);
    }
}