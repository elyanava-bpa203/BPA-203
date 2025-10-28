using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_NullableEnumStruct
{
    public class DrinkOrder
    {
        public int OrderName { get; set; }
        public string CustomerName { get; set; }
        public DrinkType Drink { get; set; }
        public DrinkSize Size { get; set; }
        public OrderStatus Status { get; set; }
        public decimal Price { get; set; }
        public object OrderNumber { get; private set; }

        public DrinkOrder(int orderName, string customerName, DrinkType drink, DrinkSize size)

        {
            OrderName = orderName;
            CustomerName = customerName;
            Drink = drink;
            Size = size;
            Status = OrderStatus.New;
            Price = CalculatePrice();



        }


        private decimal CalculatePrice()
        {
            decimal price = 0;
            switch (Drink)
            {
                case DrinkType.Coffee:
                    price = Size switch
                    {
                        DrinkSize.Small => 3m,
                        DrinkSize.Medium => 4m,
                        DrinkSize.Large => 5m,
                        _ => 0
                    };
                    break;

                case DrinkType.Tea:
                    price = Size switch
                    {
                        DrinkSize.Small => 2m,
                        DrinkSize.Medium => 3m,
                        DrinkSize.Large => 4m,
                        _ => 0
                    };
                    break;

                case DrinkType.Juice:
                    price = Size switch
                    {
                        DrinkSize.Small => 2.5m,
                        DrinkSize.Medium => 3m,
                        DrinkSize.Large => 3.5m,
                        _ => 0
                    };
                    break;

                case DrinkType.Water:
                    price = Size switch
                    {
                        DrinkSize.Small => 1m,
                        DrinkSize.Medium => 1.5m,
                        DrinkSize.Large => 2m,
                        _ => 0
                    };
                    break;



            }
            return price;


        }

        public void UpdateStatus(OrderStatus newStatus)
        {
            Status = newStatus;
            Console.WriteLine($"Sifariş: {OrderNumber} statusu: {newStatus}");
        }

        public void DisplayOrder()
        {
            Console.WriteLine($" Sifariş {OrderNumber} ");
            Console.WriteLine($"Müşteri: {CustomerName}");
            Console.WriteLine($"İçki: {Drink}");
            Console.WriteLine($"Ölçü: {Size}");
            Console.WriteLine($"Qiymet: {Price} AZN");
            Console.WriteLine($"Status: {Status}");
        }
    }
}
