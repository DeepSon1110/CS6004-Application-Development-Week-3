// Task 1 : Creating Different methods inside the Operator Class
namespace Task1
{   
    // Creating class Operators
    public class Operators
    {
        //Creating method Add
        public void Add(int a, int b)
        {
            Console.WriteLine($"Add({a}, {b}) = {a + b}");
        }

        //Creating method Subtract
        public void Subtract(int a, int b)
        {
            Console.WriteLine($"Subtract({a}, {b}) = {a - b}");
        }

        //Creating method Multiply
        public void Multiply(int a, int b)
        {
            Console.WriteLine($"Multiply({a}, {b}) = {a * b}");
        }

        //Creating method Divide
        public void Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Divide({a}, {b}) : Error: Division by zero.");
                return;
            }
            Console.WriteLine($"Divide({a}, {b}) = {a / b}");
        }

        //Creating the method OddEvenFinder
        public void OddEvenFinder(int number)
        {
            string result = (number % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine($"OddEvenFinder({number}) : {result}");
        }
    }
}