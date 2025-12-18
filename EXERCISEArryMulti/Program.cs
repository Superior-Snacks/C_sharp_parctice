namespace arrMulti
{
    class Program
    {
        static void Main(string[] args)
        {
            // fá tölu til að multi og hversu margar

            Console.Write("Enter number to mulitply: ");
            int multi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter amount desired: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] result = new int[length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = multi * (i+1);
            }

            foreach (var item in result)
            {
                Thread.Sleep(400);
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}