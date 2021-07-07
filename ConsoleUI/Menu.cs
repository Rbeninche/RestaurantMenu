using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    static class Menu
    {
        //public List<Menu> Menus = new List<Menu>();
        public static List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
        //private static int ID = 0;
        //private static int _menuID;

        static public string MenuName { get; set; }

        //static public int MenuID
        //{
        //    get
        //    {
        //        return _menuID;
        //    }
        //}
        public static DateTime LastUpdated { get; set; } = DateTime.Now;

        //public Menu(string name)
        //{
        //    ID++;
        //    this._menuID = ID;
        //    MenuName = name;
        //    LastUpdated = DateTime.Now;
        //}

        public static void AddItem(MenuItem item)
        {
            MenuItems.Add(item);
        }

        public static void PrintSingleMenuItem(MenuItem item)
        {
            Console.WriteLine("***********************");
            Console.WriteLine($"{item.MenuItemID} ----> {item.Description} ----> {item.Category} ----> {item.Price} ----> {item.Status()}");
            Console.WriteLine();

        }

        public static void RemoveItem(int id, MenuItem item)
        {
            var menuitem = MenuItems.SingleOrDefault(x => x.MenuItemID == id && x.Equals(item));
            if (item != null)
                MenuItems.Remove(menuitem);


        }



        public static void DateCreated()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"Menu created: {LastUpdated}");

            Console.ForegroundColor = ConsoleColor.White;

        }

        public static void PrintEntireMenu()
        {
            foreach (var menuItem in MenuItems)
            {
                Console.WriteLine("------------------------------------");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{menuItem.MenuItemID} | {menuItem.Description} | {menuItem.Price} | {menuItem.Category} | {menuItem.TimeAdded} | {menuItem.Status()}");

            }
        }

        //public void AddMenu(Menu menu)
        //{
        //    Menus.Add(menu);
        //}
    }
}
