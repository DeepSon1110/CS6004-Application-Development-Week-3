namespace Task2
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Task 2 \n");

   

            // --- Call NullOperations method ---
            NullOperations nullOps = new NullOperations();
            nullOps.PerformNullChecks();

            
            Console.ReadKey();
        }
    }
}