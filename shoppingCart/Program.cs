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
            string cartPath = "C:\\Users\\jonin\\source\\repos\\C_sharp_parctice\\shoppingCart\\currentShoppingCart.txt";
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
                    shoppingPath(storePath, cartPath);
                }
                else if (user.Equals(modes[1]))
                {
                    valid = true;
                    //ownerPath(); this is the loop
                }
            } while (!valid);
        }

        static void shoppingPath(string storePath, string cartPath)
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
                    shoppingCart = shopInIsle(cartPath, storePath, isleChoice);
                }
            }
            checkout(cartPath, storePath, isles);
        }
        static void displayList(List<string>ls)
        {
            //get isles from file
            for (int i = 0; i < ls.Count; i++)
            {
                Console.WriteLine(ls[i]);
            }
        }
        static List<string> shopInIsle(string cartPath, string storePath,  string isle)
        {
            //open file for isle
            List<string> items = fetchFromFile(storePath, isle, ".txt", 0, "\\");
            List<string> stock = fetchFromFile(storePath, isle, ".txt", 1, "\\");
            List<string> price = fetchFromFile(storePath, isle, ".txt", 2, "\\");
            List<string> shoppingCart;

            
            //dislay stock
            displayList(items);
            //shopping loop querry
            string hand;
            int inCart;
            do
            {
                shoppingCart = fetchFromFile(cartPath, "", "", 1, "");
                Console.Write("select item: ");
                hand = Console.ReadLine().ToLower();
                if (items.Contains(hand.ToLower()))
                {
                    int idx = Convert.ToInt32(stock[items.IndexOf(hand)]);
                    inCart = countInCart(shoppingCart, hand);
                    Console.WriteLine(idx);
                    Console.WriteLine(inCart);
                    if (idx - inCart > 0)
                    {
                        Console.WriteLine($"added {hand} to cart");
                        File.AppendAllText(cartPath, isle + "," + hand + Environment.NewLine);
                    }
                    else
                    {
                        Console.WriteLine("OUT OF STOCK");
                    }

                }
            } while (hand != "return");
            return shoppingCart;
        }

        static void checkout(string cartPath, string storePath, List<string> isles)
        {
            string currItem;
            string currIsle;
            double rlStock;
            double rlPrice;
            double runningTotal = 0;
            List<string> items;
            List<string> stock;
            List<string> price;
            List<string> shoppingCart = fetchFromFile(cartPath, "", "", 1, "");
            List<string> isle = fetchFromFile(cartPath, "", "", 0, "");
            Console.WriteLine(1);

            for (int i = 0; i < shoppingCart.Count; i++)
            {
                currItem = shoppingCart[i];
                currIsle = isle[i];

                items = fetchFromFile(storePath, currIsle, ".txt", 0, "\\");
                stock = fetchFromFile(storePath, currIsle, ".txt", 1, "\\");
                price = fetchFromFile(storePath, currIsle, ".txt", 2, "\\");
                rlStock = Convert.ToDouble(stock[items.IndexOf(currItem)]);
                rlPrice = Convert.ToDouble(price[items.IndexOf(currItem)]);
                Thread.Sleep(200);
                print($"*BEEP* {currItem} cost {rlPrice} *BEEP*");
                runningTotal += rlPrice;

                updateStockInFile(storePath, currIsle, currItem)




            }
            File.WriteAllText(cartPath, string.Empty);
            Console.WriteLine($"that will be a total of {runningTotal}$");
            Console.WriteLine("checked out");
            Console.ReadLine();
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
                if (item.Equals(hand)){
                    count++;
                }
            }
            return count;
        }

        static List<string> fetchFromFile(string storePath, string name, string fileType, int dataType=0, string slash = "\\")
        {
            List<string> result = new List<string>();
            string filePath = storePath + slash + name + fileType;
            var output = File.ReadAllLines(filePath);
            foreach (var item in output)
            {
                string[] temp = item.Split(",");
                result.Add(temp[dataType]);
            }
            return result;
        }

        static void updateStockInFile(string storePath, string isle, string itemToUpdate)
        {
            string filePath = storePath + "\\" + isle + ".txt";
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 0; i < lines.Length; i++)
            {
                // Break the line apart: "apple,10,0.99" -> ["apple", "10", "0.99"]
                string[] parts = lines[i].Split(',');

                // Check if this is the item we want
                if (parts[0].Equals(itemToUpdate, StringComparison.OrdinalIgnoreCase))
                {
                    // Parse current stock
                    int currentStock = int.Parse(parts[1]);

                    // Decrease stock
                    if (currentStock > 0)
                    {
                        currentStock--;
                        parts[1] = currentStock.ToString();
                    }

                    // Rebuild the line: "apple" + "," + "9" + "," + "0.99"
                    lines[i] = string.Join(",", parts);

                    // We found it, so we can stop looping
                    break;
                }
            }

            // Overwrite the file with the updated lines
            File.WriteAllLines(filePath, lines);
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

//TODO CHECOUT:UPDATE STOCK AND ADD TO HOME AND REMOVE FROM CART
//TODO OPTIONAL OWNER MODE