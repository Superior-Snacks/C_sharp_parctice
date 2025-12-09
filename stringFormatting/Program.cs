using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

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
            Console.WriteLine(sent[1]);
            Console.WriteLine(sent[2]);
            Console.WriteLine(sent[3]);
            Console.WriteLine(sent[4]);

            Console.WriteLine("");

            string floop = "this is a longer string";
            Console.WriteLine(floop);
            Console.WriteLine(floop.Contains("r"));
            Console.WriteLine("");
            
            for (int i = 0; i < floop.Length; i++)
            {
                Thread.Sleep(700);
                Console.Write(floop[i]);
                
            }

            Console.ReadLine();
        }
    }
}