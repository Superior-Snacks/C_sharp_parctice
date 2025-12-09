namespace stringFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "charles";
            int age = 43;

            Console.WriteLine("your name is {0}, and your age is a surpirsingly normal {1}", name, age); //hann vill
            Console.WriteLine($"your name is {name}, and your age is a surpirsingly normal {age}"); // betra?

            Console.WriteLine("name: {0}\nage {1}", name, age);

            Console.WriteLine($"name: {name}\nage {age}");

            Console.Write("enter a name: ");
            string name1 = Console.ReadLine();
            
            if (!name1.Equals(""))
            {
                Console.WriteLine($"your name is {name1}");
            }
            else
            {
                Console.WriteLine("you do not have a name?");
            }
            string sent = "Hello, World";
            Console.WriteLine(sent);
            Console.WriteLine(sent[0]);
            Console.WriteLine(sent[1:3]);


            Console.ReadLine();
        }
    }
}