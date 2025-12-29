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
                "and do not allow to take more than in stock " +
                "have a checkout process";
            Console.WriteLine(title);
            Thread.Sleep(200);
            Console.Write(t1);
            print(t1Content);
            Thread.Sleep(200);
            Console.Write(t2);
            print(t2Content);
            Thread.Sleep(200);
            Console.Write(t3);
            print(t3Content);
            Console.ReadLine();
            //mode controll, shopper, owner
            //owner: querry loop, add stock and price change
            //shopper: qerry isle displ, stock displ, add to cart loop
            bool valid = false;
            string user;
            List<string> modes = new List<string>()
            {
                "shopper", "owner"
            };
            Console.WriteLine($"{modes[0]}  {modes[1]}");
            do
            {
                Console.Write("Sellect mode: ");
                user = Console.ReadLine().ToLower();
                if (user.Equals(modes[0]))
                {
                    valid = true;
                }
                else if (user.Equals(modes[1]))
                {
                    valid = true;
                }
            } while (!valid);
            Console.WriteLine("WE GOT THROUGH");
            Console.ReadLine();
        }
        static void print(string sentance)
        {
            for (int i = 0; i < sentance.Length; i++)
            {
                Thread.Sleep(20);
                Console.Write(sentance[i]);
            }
            Console.WriteLine();
        }

        static List<string> activeShopping()
        {
            List<string> frank = new List<string>()
            {
            };
            // while loop till user goes to checkout
            return frank;
        }
        static void checkout()
        {
            //basicly a lill talk through talling up the total adding tax and stuff 
        }
        static List<string> getItemFomShelf(string item, int quantity)
        {
            List<string> frank = new List<string>()
            {
            };

            //open file see if there is A. a fitting item B. enough quantity
            //return either -1 or price
            // if second time feching then add current quantity to get to maintain the ammount in stock
            return frank;
        }
    }
}