//task 1 PrintMenu()

using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        int option = InputOption(); // Get the user's choice

        switch (option)
        {
            case 1:
                SayHelloInFrench();
                break;

            case 2:
                SayHelloInSpanish();
                break;

            case 3:
                SayHelloInGerman();
                break;

            case 4:
                SayHelloInItalian();
                break;

            case 0:
                Console.WriteLine("Exiting application.");
                break;

            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }
    }

    static int InputOption()
    {
        Console.WriteLine("Please enter a valid option from below:");
        Console.WriteLine("1. Hello in French?");
        Console.WriteLine("2. Hello in Spanish?");
        Console.WriteLine("3. Hello in German?");
        Console.WriteLine("4. Hello in Italian?");
        Console.WriteLine("0. Exit application");

        try
        {
            string choice = Console.ReadLine();
            return int.Parse(choice);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a number corresponding to your choice.");
            return -1;
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number you entered is too large or too small. Please enter a valid option.");
            return -1;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            return -1;
        }
    }

    static void SayHelloInFrench()
    {
        Console.WriteLine("Bonjour");
    }

    static void SayHelloInSpanish()
    {
        Console.WriteLine("Hola");
    }

    static void SayHelloInGerman()
    {
        Console.WriteLine("Hallo");
    }

    static void SayHelloInItalian()
    {
        Console.WriteLine("Ciao");
    }
}



