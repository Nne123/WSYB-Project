using System;

namespace ClassLibrary
{
    public class clsMenuItem
    {
        public string MenuItem { get; set; }
        public int MenuItemNo { get; set; }

        public string Valid(string someMenuItem)
        {
            string Error = "";

            if (someMenuItem.Length > 20)
            {
                Error = "the menu item cannot be more than 20 characters";
            }
            if (someMenuItem.Length < 5)
            {
                Error = "The menu item may not be blank!";
            }

            return Error;
        }
    }
}