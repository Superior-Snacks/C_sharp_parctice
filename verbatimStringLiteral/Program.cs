namespace verbatimStringLiteral
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentance = "C:\\þarf að vera tvö \\ því \\ er notað fyrir commands";
            string reglur = "\\t er fyrir \"tab\" \"\\\" er fyrir quotes í setningunni \"\\n\" fyrir næstu línu";
            Console.WriteLine(reglur);
            Console.WriteLine(sentance);
            Console.ReadLine();
        }
    }
}