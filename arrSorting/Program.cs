namespace arrSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                9,2,5,4,3,6,7,8,1,10
            };

            int[] numbers1 = new int[]
            {
                9,2,5,4,3,6,7,8,1,10
            };

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            Array.Sort(numbers);
            Console.WriteLine("sorted");
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("reversed");
            Array.Reverse(numbers);
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("array cleaeing");
            Array.Clear(numbers);
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("array index of");
            Array.IndexOf(numbers);
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}