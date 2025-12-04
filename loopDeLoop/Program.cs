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

            Console.Write("YOU DECIDE: ");
            int decision = Convert.ToInt32(Console.ReadLine());

            for ( int i = 0; i < decision; i++)
            {
                Console.WriteLine("lets go " + i);
            }

            Console.ReadLine();
        }
    }
}