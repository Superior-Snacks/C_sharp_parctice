namespace simplePasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password1 = Console.ReadLine();

            string password2;
            do
            {
                Console.Write("Re-Enter Password: ");
                password2 = Console.ReadLine();
            }
            while (!string.Equals(password1, password2));

            Console.WriteLine();
            Console.WriteLine($"CONGRATS Password set as {password1}");
            
            Console.ReadLine();
        }
    }
}