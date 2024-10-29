using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBasket
{
    internal class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDatum { get; set; }
        public double TotalPrice{ get; set; }
        
        //dictionary Produkt and INT for number of produkt
        public string Produkt { get; set; }
        public int KundNr { get; set; }
        
        public Order(int orderID, DateTime orderDatum, int totalPrice, string produkt, int kundNr)
        {
            OrderID = orderID;
            OrderDatum = orderDatum;
            TotalPrice = totalPrice;
            Produkt = produkt;
            KundNr = kundNr;

            


        }


    }
}
