using System.Net.Http.Headers;
using System.Security.Cryptography;

namespace functionParamiters
{
    class Program
    {
        static void Main(string[] args)
        {
            string thePlan = "Two study sessions 1.5 hours long";
            string teikna = "Ég vil teikna á morgun";
            string method = "Teikna með 30 min timer";

            List<string> thoughts = new List<string>()
            {
                thePlan,
                teikna,
                method
            };

            static void writeToConsole(string sent)
            {
                for (int i = 0; i < sent.Length; i++)
                {
                    //Thread.Sleep(200);
                    Console.Write(sent[i]);
                }
            }

            foreach (string tought in thoughts)
            {
                writeToConsole(tought);
                Console.WriteLine();
            }
            int numa = 5;
            int numb = 10;

            static int add(int a, int b = 30)
            {
                return a + b;
            }
            Console.WriteLine(add(numa, numb));
            Console.WriteLine(add(numa));

            static string writeName(string name = "joey")
            {
                return $"hello, {name}";
            }
            Console.WriteLine(writeName("frank"));

            string name123 = "tom";
            int age = 24;
            int adress = 1234;

            static void printDetails(string name, int age, int adress)
            {
                Console.WriteLine(name);
                Console.WriteLine(age);
                Console.WriteLine(adress);
            }
            printDetails(name: name123, age: age, adress: adress);
            Console.ReadLine();
        }
    }
}