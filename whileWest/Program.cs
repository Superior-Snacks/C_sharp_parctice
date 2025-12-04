namespace whileWest
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            while ( input != 666)
            {
                Console.Write("what is the number of the devil? ");
                input = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("YOU FOUND THE NUMBER");
            Console.ReadLine();
        }
    }
}