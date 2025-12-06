using enumerate.Entities;
using enumerate.Entities.Enums;


namespace EnumarateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product: ");
            Console.WriteLine();

            Order order = new Order
            {
                Id = 1291,
                Moment = DateTime.Now,
                Status = OrderStatus.Delivered
            };

            Console.WriteLine(order);

            Console.WriteLine();

            string txt = OrderStatus.Shipped.ToString(); // Convertendo um Enumarate para String
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); // Converter tipo String em Enumarate

            Console.WriteLine(txt);
            Console.WriteLine(os);

        }
    }
}