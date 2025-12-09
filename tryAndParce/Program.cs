using System.Threading.Channels;

namespace tryAndParce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("write number:");
            string getNumber = Console.ReadLine();
            int number = 0;

            bool sucsess = int.TryParse(getNumber, out number);
            Console.WriteLine("");

            Console.WriteLine(sucsess);
            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}