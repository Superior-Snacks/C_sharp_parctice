namespace outParam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shopping = new List<string>()
            {
                "coffe", "milk", "shugar"
            };

            static bool checker(List<string> shopping, string search, out int index)
            {
                index = -1;
                for (int i = 0; i < shopping.Count; i++)
                {
                    if (shopping[i].ToLower().Equals(search.ToLower()))
                    {
                        index = i;
                        return true;
                    }
                }
                return false;
            }
            string search = "coffe";
            Console.WriteLine(checker(shopping, search, out int found));
            Console.WriteLine(found);
            Console.ReadLine();
        }
    }
}