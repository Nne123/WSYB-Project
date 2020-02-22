using System;

namespace ClassLibrary
{
    public class clsMenuItem
    {
        public string MenuItem { get; set; }
        public int MenuItemNo { get; set; }
        public int MenuItemPrice { get; set; }

        public string Valid(string someMenuItem, string menuItemPrice)
        {
            string Error = "";
            Int32 MenuItemPrice;

            if (someMenuItem.Length > 20)
            {
                Error = "the menu item cannot be more than 20 characters";
            }
            if (someMenuItem.Length < 5)
            {
                Error = "The menu item may not be blank!";
            }

            try
            {
                MenuItemPrice = Convert.ToInt32(menuItemPrice);
                if (MenuItemPrice < 1)
                {
                    Error = Error + "The price cannot be less than £1 : ";
                }

                if (MenuItemPrice > 10)
                {
                    Error = Error + "The price cannot be more than £10 : ";
                }
            }
            catch
            {
                Error = Error + "The price was not a valid price : ";
            }

            return Error;
        }
    }
}