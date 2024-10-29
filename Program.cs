namespace ByteBasket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Order order = new Order(1, DateTime.Now, 300, "Mus", 920114);
        }
    }
}
