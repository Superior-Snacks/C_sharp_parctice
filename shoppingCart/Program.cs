using System.ComponentModel.Design;
using System.Text;

namespace shoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {/*
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
            Console.ReadLine();*/
            //mode controll, shopper, owner
            //owner: querry loop, add stock and price change
            //shopper: qerry isle displ, stock displ, add to cart loop
            string storePath = "C:\\Users\\jonin\\source\\repos\\C_sharp_parctice\\shoppingCart\\Store";
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
                    shoppingPath(storePath);
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

        static void shoppingPath(string storePath)
        {
            List<string> isles = decodeIsles(storePath);
            List<string> shoppingCart = new List<string>() {};
            displayList(isles);
            string isleChoice;
            bool shopping = true;
            while (shopping)
            {
                Console.WriteLine("while");
                do
                {
                    Console.Write("choose isle: ");
                    isleChoice = Console.ReadLine();
                } while (!isles.Contains(isleChoice) && !isleChoice.Equals("checkout"));
                if (isleChoice.Equals("checkout"))
                {
                    shopping = false;
                }
                else
                {
                    shoppingCart = shopInIsle(shoppingCart, storePath, isleChoice);
                }
            }
            checkout(shoppingCart);
        }
        static void displayList(List<string>ls)
        {
            //get isles from file
            for (int i = 0; i < ls.Count; i++)
            {
                Console.WriteLine(ls[i]);
            }
        }
        static List<string> shopInIsle(List<string> shoppingCart, string storePath,  string isle)
        {
            //open file for isle
            List<string> items = fetchFromFile(storePath, isle, 0);
            List<string> stock = fetchFromFile(storePath, isle, 1);
            List<string> price = fetchFromFile(storePath, isle, 2);
            
            //dislay stock
            displayList(stock);
            //shopping loop querry
            string hand;
            int inCart
            do
            {
                Console.Write("select item: ");
                hand = Console.ReadLine().ToLower();
                if (items.Contains(hand.ToLower()))
                {
                    int idx = items.Index(hand);
                    inCart = countInCart(shoppingCart, hand)
                    if (stock[idx] - inCart >= 0)
                    {
                        Console.WriteLine($"added {hand} to cart");
                        //update shoppingCArt
                    }

                }
                //make sure item is spelled correct case insenitive
                //make sure item is in stock
                //add to cart
            } while (hand != "return");
            return shoppingCart;
        }

        static void checkout(List<string> shoppingCart)
        {
            //go through the lsit in a for loop print out the list and the price adding tax as it goes
            //add litle chats 
            //goodbye
            Console.WriteLine("done");
        }

        static List<string> decodeIsles(string path)
        {
            List<string> isles = new List<string>();
            string fileName;
            foreach (string file in Directory.EnumerateFiles(path))
            {
                fileName = Path.GetFileNameWithoutExtension(file);
                isles.Add(fileName);
                Console.WriteLine(fileName);
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

        static int countInCart(List<string> shoppingCart, string hand)
        {
            int count = 0;
            foreach (string item in shoppingCart)
            {
                if item.Equals(hand){
                    count++;
                }
            }
            return count;
        }

        static List<string> fetchFromFile(string storePath, string name, int dataType=0)
        {
            List<string> result = new List<string>();
            string filePath = storePath + "\\" + name + ".txt";
            Console.WriteLine(filePath);
            Console.ReadLine();
            var output = File.ReadAllLines(filePath);
            foreach (var item in output)
            {
                string[] temp = item.Split(",");
                result.Add(temp[dataType]);
            }
            return result;
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