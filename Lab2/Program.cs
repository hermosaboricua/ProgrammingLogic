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
    }
}