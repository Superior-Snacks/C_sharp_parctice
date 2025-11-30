namespace OddEvenChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            //common knowlage the remainder of a number divided by 2 is o if even and 1 if odd
            const int value = 11;

            int check = value % 2;

            Console.WriteLine(check);

            if (check == 1)
            {
                Console.WriteLine("Odd");
            }
            else if (check == 0)
            {
                Console.WriteLine("Even");
            }
            Console.ReadLine();
        }
    }
}