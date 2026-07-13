namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

         // Declare integer variables

        int a = 10;

        int b = 5;

        int c = 15;

        // Comparison and logical operators

        Console.WriteLine("a > b: " + (a > b));

        Console.WriteLine("a < c: " + (a < c));

        Console.WriteLine("a > b && a > c: " + (a > b && a > c));

        Console.WriteLine("a > b || a > c: " + (a > b || a > c));

        // Declare boolean variables

        bool isRaining = true;

        bool haveUmbrella = false;

        // Check the conditions

        if (isRaining && !haveUmbrella)
        {
            Console.WriteLine("Take an umbrella!");
        }
        else
        {
            Console.WriteLine("You're good to go!");
        }
        // Ask the user for their age

        Console.Write("Enter your age: ");

        int age = int.Parse(Console.ReadLine()!);

        // Determine the ticket price

        if (age < 5)

        {

            Console.WriteLine("Ticket is free!");

        }

        else if (age >= 5 && age <= 12)

        {

            Console.WriteLine("Child ticket: $5");

        }

        else if (age >= 13 && age <= 64)

        {

            Console.WriteLine("Standard ticket: $10");

        }

        else

        {

            Console.WriteLine("Senior ticket: $6");

        }

    }

}
