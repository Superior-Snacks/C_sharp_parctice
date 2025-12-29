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
            displayIsle(isles);
            string isleChoice;
            do
            {
                Console.Write("choose isle: ");
                isleChoice = Console.ReadLine();
            } while (!isles.Contains(isleChoice);
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
        }

        static List<string> decodeIsles()
        {
            //get name of files in folder
            List<string> isles = new List<string>() {
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