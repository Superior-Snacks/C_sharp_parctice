namespace listicles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list_structure = new List<int>() // lookie here list syntax
            {
                1,2,3,4,5
            };
            foreach (var item in list_structure)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}