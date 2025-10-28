
using _13_NullableEnumStruct;
using System;

class Program
{
    static void Main()
    {
       
        DrinkOrder order1 = new DrinkOrder(101, "Elyana", DrinkType.Coffee, DrinkSize.Medium);
        order1.DisplayOrder();
        order1.UpdateStatus(OrderStatus.Preparing);
        order1.UpdateStatus(OrderStatus.Ready);
        order1.UpdateStatus(OrderStatus.Delivered);

        DrinkOrder order2 = new DrinkOrder(102, "Zema", DrinkType.Tea, DrinkSize.Large);
        order2.DisplayOrder();
        order2.UpdateStatus(OrderStatus.Ready);

        DrinkOrder order3 = new DrinkOrder(103, "Aytac", DrinkType.Juice, DrinkSize.Small);
        order3.DisplayOrder();

        Console.WriteLine(" Enum Deyerleri ");

        Console.WriteLine("\nDrinkType deyerleri:");
        foreach (var d in Enum.GetValues(typeof(DrinkType)))
            Console.WriteLine(d);

        Console.WriteLine("\nDrinkSize deyerleri:");
        foreach (var s in Enum.GetValues(typeof(DrinkSize)))
            Console.WriteLine(s);

        Console.WriteLine("\nOrderStatus deyerleri:");
        foreach (var st in Enum.GetValues(typeof(OrderStatus)))
            Console.WriteLine(st);

        Console.WriteLine("\nToString() nümuneleri:");
        Console.WriteLine(DrinkType.Coffee.ToString());
        Console.WriteLine(DrinkSize.Large.ToString());

        Console.WriteLine("\nParse() nümuneleri:");
        DrinkType parsedDrink = (DrinkType)Enum.Parse(typeof(DrinkType), "Tea");
        DrinkSize parsedSize = (DrinkSize)Enum.Parse(typeof(DrinkSize), "Medium");
        Console.WriteLine($"Parsed Drink: {parsedDrink}");
        Console.WriteLine($"Parsed Size: {parsedSize}");




        Console.WriteLine("\n--- Statistika ---");
        Console.WriteLine($"Ümumi sifariş sayi: 3");
        Console.WriteLine($"1-ci sifarişin qiymeti: {order1.Price} AZN");
        Console.WriteLine($"2-ci sifarişin qiymeti: {order2.Price} AZN");
        Console.WriteLine($"3-cü sifarişin qiymeti: {order3.Price} AZN");

        decimal total = order1.Price + order2.Price + order3.Price;
        Console.WriteLine($"Ümumi mebleğ: {total} AZN");
    }
}
