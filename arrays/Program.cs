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

            Console.WriteLine($"{numbers[0]}, {numbers[1]}, {numbers[2]}");


            Console.ReadLine();
        }
    }
}