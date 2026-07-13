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
{

        // Ask the user to enter a day number

        Console.Write("Enter a day of the week (1-7): ");

        int day = int.Parse(Console.ReadLine()!);

        // Display the corresponding day

        switch (day)

        {

            case 1:

                Console.WriteLine("Monday");

                break;

            case 2:

                Console.WriteLine("Tuesday");

                break;

            case 3:

                Console.WriteLine("Wednesday");

                break;

            case 4:

                Console.WriteLine("Thursday");

                break;

            case 5:

                Console.WriteLine("Friday");

                break;

            case 6:

                Console.WriteLine("Saturday");

                break;

            case 7:

                Console.WriteLine("Sunday");

                break;

            default:

                Console.WriteLine("Invalid day!");

                break;

        }

    }

}
        }

    }


