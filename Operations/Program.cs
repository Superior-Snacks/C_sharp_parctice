namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = 24;
            age++;
            Console.WriteLine(age);
            age = age + 1;
            Console.WriteLine(age);
            age += 10;
            Console.WriteLine(age);
            age--;
            Console.WriteLine(age);
            age *= 11;
            Console.WriteLine(age);
            age /= 10;
            Console.WriteLine(age);

            string name = "abba";
            name += " is a good band";
            Console.WriteLine(name);

            char letter = 'a';
            letter += 'b';
            Console.WriteLine(letter);

            int i = 0;
            i++;
            Console.WriteLine(i);

            Console.WriteLine(i++); //returnar i svo ++ þannig enging breyting sést
            Console.WriteLine(++i); // fix?

            Console.WriteLine("--------------------------------------------");

            //remainder 
            int first = 10;
            int second = 3;

            // 10 / 3 = 3 r 1
            // 3 x 3 = 9 r 1
            Console.WriteLine(first % second); // 1

            // 10 % 2 = 0
            // 11 % 2 = 1
            // 12 % 2 = 0
            Console.WriteLine(first % 2); // 0
            Console.WriteLine(second % 2); // 1

            Console.WriteLine(1000 % 90); // 10
            Console.WriteLine(71 % 10); // 1
            Console.ReadLine();
        } 
    }
}