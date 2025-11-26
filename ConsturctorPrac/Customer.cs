namespace Myapp
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
}