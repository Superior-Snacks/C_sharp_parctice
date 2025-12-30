using System.ComponentModel.Design;
using System.Text;

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
                    shoppingPath();
                }
                else if (user.Equals(modes[1]))
                {
                    valid = true;
                    //ownerPath(); this is the loop
                }
            } while (!valid);
            Console.WriteLine("WE GOT THROUGH");
            Console.ReadLine();
        }

        static void shoppingPath()
        {
            List<string> isles = decodeIsles();
            List<string> shoppingCart = new List<string>() {};
            displayList(isles);
            string isleChoice;
            bool shopping = true;
            while (shopping)
            {
                do
                {
                    Console.Write("choose isle: ");
                    isleChoice = Console.ReadLine();
                } while (!isles.Contains(isleChoice) || isleChoice.Equals("checkout");
                shoppingCart = shopInIsle(shoppingCart, isleChoice);
            }
            //loop for isle sellect
            //loop for item sellect
            //return from isle
            //send list to checkout
            //end script

        }
        static void displayList(List<string>ls)
        {
            //get isles from file
            for (int i = 0; i < ls.Count; i++)
            {
                Console.WriteLine(ls[i]);
            }
        }
        static List<string> shopInIsle(List<string> shoppingCart, string isle)
        {
            //open file for isle
            List<string> stock = fetchFromFile(isle);
            //dislay stock
            displayList(stock);
            //shopping loop querry
            string hand;
            do
            {
                Console.Write("select item: ");
                hand = Console.ReadLine();
                //make sure item is spelled correct case insenitive
                //make sure item is in stock
                //add to cart
            } while (hand != "return");
            return shoppingCart;
        }

        static List<string> decodeIsles()
        {
            //get name of files in folder
            List<string> isles = new List<string>() { // temp
                "dairy",
                "meat",
                "canned"
            };
            return isles;
        }

        static void ownerPath()
        {
            //loop for isle
            //prompt for adding stock or adding item
            //add stock or item
            //end script from wherever
        }

        static List<string> fetchFromFile(string name)
        {
            //from folder isles
            //fech filename
        }

        static void print(string sentance)
        {
            for (int i = 0; i < sentance.Length; i++)
            {
                Thread.Sleep(5);
                Console.Write(sentance[i]);
            }
            Console.WriteLine();
        }
    }
}