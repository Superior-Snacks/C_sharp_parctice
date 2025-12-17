namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;

            int[] numbers = new int[3];

            Console.Write("Enter a number: ");
            numbers[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number: ");
            numbers[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number: ");
            numbers[2] = Convert.ToInt32(Console.ReadLine());

            string[] goals = new string[3];

            goals[0] = "CODING";
            goals[1] = "DRAWING";
            goals[2] = "WORKING";


            Console.WriteLine($"{numbers[0]}, {numbers[1]}, {numbers[2]}");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("I'M NOT FUCKING STOPPING ");
                Console.WriteLine(goals[i]);
                Thread.Sleep(400);
                Console.WriteLine(numbers[i]);

            }

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Thread.Sleep(400);
                Console.WriteLine(numbers[i]);
            }

            foreach (var num in numbers)
            {
                Console.Write(num);
            }


            Console.ReadLine();
        }
    }
}