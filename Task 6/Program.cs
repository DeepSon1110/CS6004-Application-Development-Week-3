using System;

class Program
{
    static void Main(string[] args)
    {
        // Number Conversion
        try
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            // Try converting user input to integer
            int number = Convert.ToInt32(input);

            Console.WriteLine("You entered number: " + number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number format");
        }
        finally
        {
            Console.WriteLine("Program Executed");
        }

        // Password Validation
        try
        {
            Console.Write("\nEnter your password: ");
            string password = Console.ReadLine();

            // If password is too short, manually throw an exception
            if (password.Length < 6)
            {
                throw new Exception("Password must be at least 6 characters.");
            }
            else
            {
                Console.WriteLine("Password satisfied the requirement");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadLine(); // 
    }
}
