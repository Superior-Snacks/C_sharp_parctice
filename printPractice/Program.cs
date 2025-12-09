namespace printPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //print input in reverse
            Console.Write("enter string: ");
            string sentance = Console.ReadLine();
            Console.WriteLine(sentance.Length);

            for (int i = 0; i < sentance.Length; i++)
            {
                Thread.Sleep(300);
                Console.Write(sentance[i]);
            }
            Console.WriteLine("");

            for (int i = sentance.Length - 1; i >= 0; i--)
            {
                Thread.Sleep(300);
                Console.Write(sentance[i]);
            }
            Console.ReadLine();
        }
    }
}