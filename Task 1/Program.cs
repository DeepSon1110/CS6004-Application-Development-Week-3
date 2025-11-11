//Creating same namespace for both Operators.cs & Program.cs
namespace Task1
{
    class Program
    {
        //main method
        static void Main(string[] args)
        {
            Operators ops = new Operators();

            Console.WriteLine("Task1\n");

            // Arithmetic operations
            ops.Add(15, 10);
            ops.Subtract(15, 10);
            ops.Multiply(15, 10);
            ops.Divide(15, 10);
            ops.Divide(20, 0);

            Console.WriteLine();

            // Odd/Even checks
            ops.OddEvenFinder(4);
            ops.OddEvenFinder(9);
            ops.OddEvenFinder(0);
            ops.OddEvenFinder(-5);
            ops.OddEvenFinder(-6);

            Console.WriteLine("\n Task1 completed successfully.");
            Console.ReadKey();
        }
    }
}