namespace InputsOutputs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("yo my name is updawg");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            //Console.WriteLine("good evening " + name);

            Console.Write("and what is your age: ");
            string age = Console.ReadLine();
            //Console.WriteLine("an outrageous age of " + age);

            //sleppa line svo allt endar á sömu línu
            Console.Write("your name is ");
            Console.Write(name);
            Console.Write(" and your age is "); 
            Console.Write(age);

            Console.ReadLine();
        }
    }
}