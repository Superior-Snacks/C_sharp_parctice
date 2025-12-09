using System.Threading.Channels;

namespace tryAndParce
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = 0;
            //bool sucsess = int.TryParse(getNumber, out number);

            // tryparce skilar 0 of boolean false
            bool sucsess = true;
            while (sucsess)
            {
                Console.Write("write number:");
                string getNumber = Console.ReadLine();

                if (int.TryParse(getNumber, out int number))
                {
                    sucsess = false;
                    Console.WriteLine("True");
                    Console.WriteLine("sucessful input!!!");
                    Console.WriteLine(number);
                }
                else
                {
                    Console.WriteLine("False");
                    Console.WriteLine("YOU FAIL TO LIVE!!!!1");
                }
            }


            Console.ReadLine();
        }
    }
}