namespace ByteBasket
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order(1, DateTime.Now, 300, "Mus", 920114);
          
            Kund kund = new Kund("max", "poerthansvägen 12", 205110001, 0707254431, "Maxlundberg@protonmail.com");
            Console.WriteLine("hej");
            

        }
    }
}
