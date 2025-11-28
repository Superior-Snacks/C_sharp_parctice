// See https://aka.ms/new-console-template for more information
namespace WorldHi
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            age = 23;
            int betterage = 23;

            long bigNum = -90000000000L;
            Console.WriteLine("{0}, {1}", age, betterage);
            Console.WriteLine(bigNum);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue);

            double neg = 55.23;
            Console.WriteLine(neg);
            Console.WriteLine(double.MaxValue);

            float evenLarger = 5.9999999F;

            Console.WriteLine(evenLarger);
            Console.WriteLine(float.MaxValue);

            decimal curr = 14.99M;
            Console.WriteLine(curr);
            Console.WriteLine(decimal.MaxValue);



            Console.ReadLine();
        }
    }
}