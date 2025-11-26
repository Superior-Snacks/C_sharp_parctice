using System.Collections.Generic;

namespace Myapp
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;
        public Customer()
        {
            Orders = new List<Order>();
        }
        public Customer(int id) //constructorinn hefur nákvæmlega sama nafn of classinn einginn return type
            : this()
        {                   // staður til að init defaoult stillir allt í 0, False, None
            this.Id = id;
        }
        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    }
    public class Order
    {
        
    }
}