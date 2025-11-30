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
            Console.ReadLine();
        } 
    }
}