namespace loopDeLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("yo!");
                Console.WriteLine(i);
            }

            for (int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}