using Systems.Collections.Generic;

namespace Myapp
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;
        public Customer()
        {
        }
        public Customer(int id) //constructorinn hefur nákvæmlega sama nafn of classinn einginn return type
        {                   // staður til að init defaoult stillir allt í 0, False, None
            this.Id = id;
        }
        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
    public class Order
    {
        
    }
}