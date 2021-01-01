using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fields
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);

            var order = new Order();

            customer.Orders.Add(order);
            customer.Orders.Add(order);
            
            Console.WriteLine(customer.Orders.Count);

        }
    }
}
