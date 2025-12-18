namespace functionsLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem();
            Console.WriteLine(number());
            Console.WriteLine(answer("tom"));
            Console.ReadLine();
        }
        static void Problem()
        {
            Console.WriteLine("wtf");
        }
        static int number()
        {
            return 42;
        }
        static string answer(string args)
        {
            return $"hello {args}";
        }
    }
}