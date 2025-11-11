//Task 3 : If else and switch

// Creating class Program
class Program
{
    //creating main method
    static void Main()
    {
        Console.Write("Please enter your age: ");
        string input = Console.ReadLine();

        // Trying to parse the input to an integer safely as input takes string 
        if (int.TryParse(input, out int age))
        {
            if (age < 13)
            {
                Console.WriteLine("Child");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("Teenager");
            }
            else 
            {
                Console.WriteLine("Adult");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}