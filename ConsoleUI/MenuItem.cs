using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleUI
{
    //price, description, and category
    class MenuItem
    {
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        private static int ID = 0;
        private int _menuItemID = 0;

        public int MenuItemID
        {
            get { return _menuItemID; }
        }

        public DateTime TimeAdded { get; set; } = DateTime.Now;

        public MenuItem()
        {
            ID++;
            this._menuItemID = ID;

        }

        public MenuItem(double price, string description, string category, DateTime timeAdded)
        {
            Price = price;
            Description = description;
            Category = category;
            TimeAdded = timeAdded;
            ID++;
            this._menuItemID = ID;

        }

        public MenuItem(double price, string description, string category) : this(price, description, category, DateTime.Now)
        {

        }

        public string Status()
        {
            //Convert.ToInt32(myTimeSpan.TotalDays)

            TimeSpan value = DateTime.Now.Subtract(TimeAdded);
            int valueInt = Convert.ToInt32(value.TotalDays);

            if (valueInt < 365)
            {

                return $"Updated {valueInt} days ago -(NEW)";
            }

            return $"Updated {valueInt} days - (OLD)";
        }

        public void Update([Optional]double price, [Optional] string description, [Optional] string category)
        {
            double oldPrice;
            oldPrice = Price;
            string oldDescription = Description, oldCategory = Category;
            Price = price;
            Description = description;
            Category = category;
            if (!oldPrice.Equals(price) || !oldDescription.Equals(description) || !oldCategory.Equals(category))
            {
                TimeAdded = DateTime.Now;
            }

        }

        public override bool Equals(object toBeCompared)
        {

            if (toBeCompared == this)
            {
                return true;
            }

            if (toBeCompared == null)
            {
                return false;
            }

            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            }

            MenuItem m = toBeCompared as MenuItem;
            return m.MenuItemID == MenuItemID;
        }

        public override int GetHashCode()
        {
            // Which is preferred?

            return base.GetHashCode();




        }
    }
}
