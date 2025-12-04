namespace doneWhile
{
    class Project
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MATH TIME!!!");
            Console.WriteLine("enter two numbers");
            Console.Write("number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int correct = number1 + number2;

            Console.WriteLine("");
            Console.Write("ok now calculate " + number1 + " + " + number2 + " = ");
            int answer;
            Console.WriteLine("");
            do
            {
                Console.Write("enter answer: ");
                answer = Convert.ToInt32(Console.ReadLine());

                if (answer != correct)
                {
                    Console.WriteLine("boo ass at this man");
                }
            }
            while (answer != correct);
            Console.WriteLine("!!!! CONGRATS !!!!!!");
           
            Console.ReadLine();
        }
    }
}