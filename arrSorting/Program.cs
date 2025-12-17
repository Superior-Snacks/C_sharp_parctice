namespace arrSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10]
            {
                1,2,3,4,5,6,7,8,9,10
            };

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}