namespace verbatimStringLiteral
{
    class Program
    {
        static void Main(string[] args)
        {
            int example = 2;
            string sentance = "C:\\þarf að vera tvö \\ því \\ er notað fyrir commands";
            string reglur = "\\t er fyrir \"tab\" \"\\\" er fyrir quotes í setningunni \"\\n\" fyrir næstu línu";
            Console.WriteLine(reglur);
            Console.WriteLine(sentance);

            string added_string = "hello pal, " + example;
            string formatted_string = $"hello world {example}";
            Console.WriteLine(added_string);
            Console.WriteLine(formatted_string);

            string verbatum = @"C:\þarf að vera tvö \ því \ er notað fyrir commands";
            Console.WriteLine(verbatum);

            string quote = @"you are a ""bitch""";
            string quote2 = "'pisser'";
            Console.WriteLine(quote);
            Console.WriteLine(quote2);

            Console.ReadLine();
        }
    }
}