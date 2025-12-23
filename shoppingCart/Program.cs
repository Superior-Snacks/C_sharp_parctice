namespace shoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "TODO";
            string t1 = "shoppingcart: ";
            string t1Content = "adding list of items";
            string t2 = "market: ";
            string t2Content = "a dictionary of items for sale with price and quantiy availabel";
            string t3 = "logic: ";
            string t3Content = "add only to cart if spelled correctly, " +
                "remove from stock when added to cart " +
                "and do not allow to take more than in stock" +
                "have a checkout process";
            Console.WriteLine(title);
            Thread.Sleep(200);
            Console.Write(t1);
            print(t1Content);
            Thread.Sleep(200);
            Console.WriteLine(t2);
            print(t2Content);
            Thread.Sleep(200);
            Console.WriteLine(t3);
            print(t3Content);
            Console.ReadLine();
        }
        static void print(string sentance)
        {
            for (int i = 0; i < sentance.Length; i++)
            {
                Thread.Sleep(200);
                Console.Write(sentance[i]);
            }
            Console.WriteLine();
        }
    }
}