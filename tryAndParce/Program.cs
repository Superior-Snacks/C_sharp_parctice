using System.Threading.Channels;

namespace tryAndParce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("write number:");
            string getNumber = Console.ReadLine();
            
            //int number = 0;
            //bool sucsess = int.TryParse(getNumber, out number);

            if (int.TryParse(getNumber, out int number))
            {
                Console.WriteLine("True");
                Console.WriteLine("sucessful input!!!");
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("False");
                Console.WriteLine("YOU FAIL TO LIVE!!!!1");
            }

            Console.ReadLine();
        }
    }
}