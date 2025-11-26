//wtf eru constructors
// meathod se er called um leið og class er created þ.e þegar class er fyrst notað fyrir object init 
//why? init það þarf að fylla sum fields
namespace ConstructiorPractice
{
    public class Customer
    {
        public int id;
        public string Name;
        public Customer(string name) //constructorinn hefur nákvæmlega sama nafn of classinn einginn return type
        {                   // staður til að init defaoult stillir allt í 0, False, None
            this.Name = name;
        }
        public Customer(int id, string name)
        {
            
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer("thomas");
        }
    }
}