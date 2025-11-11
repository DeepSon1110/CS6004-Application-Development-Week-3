//Task 5 : Loops

//creating class Program
class Program
{   
    //creating main method
    static void Main()
    {
        Console.WriteLine(" Task 1: Sum from 1 to N using for loop ");
        SumFrom1ToN();

        Console.WriteLine("\n Task 2: Print 1–20 with while loop (skip multiples of 4, break at 15) ");
        PrintWithWhile();

        Console.WriteLine("\n Task 3: Sum array elements using foreach ");
        SumArrayWithForeach();
    }

    // Task 1: Sum from 1 to N using for loop
    static void SumFrom1ToN()
    {
        Console.Write("Enter a number N: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n >= 1)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Sum from 1 to {n} = {sum}");
        }
        else
        {
            Console.WriteLine("Please enter a positive integer.");
        }
    }

    // Task 2: Print numbers 1 to 20 using while loop
    static void PrintWithWhile()
    {
        int num = 1;
        while (num <= 20)
        {
            if (num % 4 == 0)
            {
                num++;
                continue; 
            }

            if (num == 15)
            {
                break; 
            }

            Console.Write(num + " ");
            num++;
        }
        Console.WriteLine(); 
    }

    // Task 3: Sum elements in an array using foreach
    static void SumArrayWithForeach()
    {
        // Example array — you can change values or make it user-input if needed
        int[] numbers = { 10, 20, 30, 5, 15 };

        Console.WriteLine($"Array: [{string.Join(", ", numbers)}]");
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"Sum of all elements = {sum}");
    }
}