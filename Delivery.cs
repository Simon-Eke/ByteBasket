using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBasket
{
    public interface IDelivery
    {
        void Delivery_method();
    }
    public abstract class Delivery()
    {
        public Order Order { get; set; }
        public Kund Customer { get; set; }

        public void Delivery_Method()
        {
            Console.WriteLine($"the  Order {Order.Id} for {Customer.Name} at {Customer.Adress} is in transit");
        }
    }
    public class Standard : Delivery, IDelivery 
    {

    }
    public class Expres : Delivery, IDelivery
    { 
    
    }
    
}
