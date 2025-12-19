namespace outParam
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            test(num);
            Console.WriteLine(num);
            Console.WriteLine(test(num));
            static int test(int num)
            {
                num = 0;
            }
            Console.ReadLine();
        }
    }
}