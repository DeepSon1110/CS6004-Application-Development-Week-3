//Task 2 : Null Operations


namespace Task2 
{

    //Creating class nullOperator   
    public class NullOperations
    {
        public void PerformNullChecks()
        {
            string username = null;

            Console.WriteLine(" Null Check \n");

            //Using Ternary Operator (? :)
            Console.WriteLine("1. Ternary Operator Check:");
            string result1 = username == null ? "Username is not available" : username;
            Console.WriteLine(result1);

            //Using Null-Coalescing Operator (??)
            Console.WriteLine("\n2. Null-Coalescing Operator (??):");
            string result2 = username ?? "Username is not available";
            Console.WriteLine(result2);

            //Using Null-Coalescing Assignment Operator (??=)
            Console.WriteLine("\n3. Null-Coalescing Assignment Operator (??=):");
            username ??= "DefaultUser"; 
            Console.WriteLine($"username after assignment: \"{username}\"");

            // Final print of updated username
            Console.WriteLine($"\n Final username value: {username}");
        }
    }
}

