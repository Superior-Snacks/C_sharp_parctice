namespace formatting
{
    class Project
    {
        static void Main(string[] args)
        {
            double number = 15.123456789;

            Console.WriteLine(number);
            Console.WriteLine(string.Format("{0:0.0}",number));
            Console.WriteLine(string.Format("{0:0.00}", number));
            Console.WriteLine(string.Format("{0:0.000} {1:0.00000}", number, number));

            Console.WriteLine(number.ToString("C"));

            Console.ReadLine();
        }
    }
}