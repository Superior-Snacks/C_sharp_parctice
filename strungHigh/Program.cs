namespace StringChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "thomas";
            char letter = 'c';

            Console.WriteLine("your name is {0} the letter for you is {1}", name, letter);
            Console.WriteLine(name);
            Console.WriteLine(letter);

            string textAge = "-48";
            int age = Convert.ToInt32(textAge);
            age += 100;
            age--;
            --age;
            Console.WriteLine(age);
            Console.WriteLine(textAge);

            Console.ReadLine();
        }
    }
}