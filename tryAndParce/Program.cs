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

            if (sucsess)
            {
                Console.WriteLine(sucsess);
                Console.WriteLine("sucessful input!!!");
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine(sucsess);
                Console.WriteLine("YOU FAIL TO LIVE!!!!1");
            }
                Console.WriteLine("");

            Console.WriteLine(sucsess);
            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}