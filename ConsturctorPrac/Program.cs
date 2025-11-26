//wtf eru constructors
// meathod se er called um leið og class er created þ.e þegar class er fyrst notað fyrir object init 
//why? init það þarf að fylla sum fields
using Myapp;
using System;

namespace ConstructiorPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "thomas");
            System.Console.WriteLine(customer.Name);
            System.Console.WriteLine(customer.Id);
        }
    }
}