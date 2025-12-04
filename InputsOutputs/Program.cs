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
            int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("an outrageous age of " + age);

            //sleppa line svo allt endar á sömu línu
            //Console.Write("your name is ");
            //Console.Write(name);
            //Console.Write(" and your age is "); 
            //Console.WriteLine(age);

            Console.WriteLine("your name is " + name + " and your age is " + age);
            if (name == "Frank")
            {
                Console.WriteLine("FRANK YOU FUCK YOU KNOW YOU ARE BANNED!!!!");
            }
            else
            {
                if (age > 21 && age <25)
                {
                    Console.WriteLine("welcome " + name + " you are over the legal limmit and are " + age);
                }
                else if (age == 21)
                {
                    Console.WriteLine("aaah just made it fam!!");
                }
                else if (age >= 25 && age <= 150)
                {
                    Console.WriteLine("YOOO A OLDIE IN THE BUILDING");
                }
                else if (age < 0 || age >= 150)
                {
                    Console.WriteLine("NAAH bruh done faked his age");
                }
                else
                {
                    Console.WriteLine("bro wtf you are way too young " + age + " is not permitted");
                }
            }

            Console.WriteLine("MATH TIME!!!");
            Console.WriteLine("enter two numbers");
            Console.Write("number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int correct = number1 + number2;

            Console.WriteLine("");
            Console.Write("ok now calculate " + number1 + " + " + number2 + " = ");
            int anwser = Convert.ToInt32(Console.ReadLine());

            if (anwser == correct)
            {
                Console.WriteLine("!!!!! CORRECT YOU DONE DID IT !!!!!!!");
            }
            else
            {
                Console.WriteLine("boo ass at this man");
            }

                Console.ReadLine();
        }
    }
}