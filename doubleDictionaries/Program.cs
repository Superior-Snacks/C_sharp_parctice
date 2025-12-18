namespace doubleDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> names = new Dictionary<int, string>();
            names.Add(0, "Jón");
            names.Add(1, "Jón1");
            names.Add(2, "Jón2");
            names.Add(3, "Jón3");
            KeyValuePair<int, string> got = names.ElementAt(2);
            Console.WriteLine($"{got.Key} - {got.Value}");
            Console.ReadLine();
        }
    }
}