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
        void Delivery();
    }
    public abstract class Delivery()
    {
        public Order Order { get; set; }

        public void Delivery()
        {
            Console.WriteLine($"the  Order {Order.Id} for {Kund.Name} at {Kund.Adress} is in transit");
        }
    }
    public class Standard : Delivery, IDelivery 
    {

    }
    public class Expres : Delivery, IDelivery
    { 
    
    }
    
}
