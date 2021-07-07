using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem pizza = new MenuItem(12.65, "Peperonni", "Dinner", new DateTime(2020, 06, 20));
            MenuItem straberrySalad = new MenuItem(11.49, "Strawberry Poppyseed Salad with Chicken", "Dinner", new DateTime(2021, 06, 20));
            MenuItem icecream = new MenuItem(6.35, "Creme a la grace", "Dessert");

            //Menu topPizza = new Menu("Top-Pizza");
            //Menu salad = new Menu("Salads");


            Menu.DateCreated();
            Menu.AddItem(pizza);
            Menu.AddItem(straberrySalad);
            Menu.AddItem(icecream);
            pizza.Description = "Peperonni";
            pizza.Update(5.99, pizza.Description, pizza.Category);

            //Console.WriteLine("Before removing");
            //Menu.PrintEntireMenu();

            //Menu.RemoveItem(4, pizza);
            Console.WriteLine("After removing");

            //Menu.PrintSingleMenuItem(pizza);

            //Menu.PrintSingleMenuItem(straberrySalad);


            //Console.WriteLine(pizza.TimeAdded);

            Menu.PrintEntireMenu();
            Console.WriteLine();

           

            var dinnerCategory = Menu.MenuItems.FindAll(c => c.Category == "Dessert");

            

            Console.WriteLine("This will print only dinner category");
            //foreach (var item in dinnerCategory)
            //{
            //    Console.WriteLine($"{item.Category} : {item.Description}");

            //}
            dinnerCategory.ForEach(x => Console.WriteLine($"{x.Category} : {x.Description}"));


            Console.ReadLine();
        }
    }
}
