using System;

namespace ClassLibrary
{
    public class clsMenuItem
    {
        // private data member for the MenuItemNo
        private Int32 mMenuItemNo;
        // private data member for the MenuItemNo
        private string mMenuItem;
        // private data member for the MenuItemPrice
        private Int32 mMenuItemPrice;

        // public property for menu item
        public string MenuItem
        {
            get
            {
                // return the private data
                return mMenuItem;
            }
            set
            {
                // set the private data
                mMenuItem = value;
            }
        }
        // public property for menu item no
        public int MenuItemNo
        {
            get
            {
                // return the private data
                return mMenuItemNo;
            }
            set
            {
                // set the private data
                mMenuItemNo = value;
            }
        }

        // public property for menu price 
        public int MenuItemPrice
        {
            get
            {
                // return the menu item price
                return mMenuItemPrice;
            }
            set
            {
                // set the private data
                mMenuItemPrice = value;
            }
        }

        // validation method for menu class
        public string Valid(string menuItem, string menuItemPrice)
        {
            // create a string vairable to store the error 
            String Error = "";
            // create a temporary variable to store the menu item price
            Int32 MenuItemPrice;
            // if the menu item is greater than 20 characters
            if (menuItem.Length > 20)
            {
                // record the error
                Error = "the menu item cannot be more than 20 characters";
            }
            // if the menu item is less than 1 character
            if (menuItem.Length < 1)
            {
                // record the error
                Error = "The menu item may not be blank!";
            }

            try
            {
                // copy the menuItem value to the menuItemPrice variable
                MenuItemPrice = Convert.ToInt32(menuItemPrice);
                if (MenuItemPrice < 1)
                {
                    // record the error
                    Error = Error + "The price cannot be less than £1 : ";
                }
                // check to see if the menu item price is greater than 10
                if (MenuItemPrice > 10)
                {
                    // record the error
                    Error = Error + "The price cannot be more than £10 : ";
                }
            }
            catch
            {
                // record the error
                Error = Error + "The price was not a valid price : ";
            }

            return Error;
        }

        public bool Find(int MenuItemNo)
        {
            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the menu item no to search for
            DB.AddParameter("@MenuItemNo", MenuItemNo);
            // execute the stored procedure
            DB.Execute("sproc_tblMenuItem_FilterByMenuItemNo");
            // if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                // copy the data from the database to the private data members
                mMenuItemNo = Convert.ToInt32(DB.DataTable.Rows[0]["MenuItemNo"]);
                mMenuItem = Convert.ToString(DB.DataTable.Rows[0]["MenuItem"]);
                mMenuItemPrice = Convert.ToInt32(DB.DataTable.Rows[0]["MenuItemPrice"]);
                // return that everything worked OK
                return true;
            }
            // if no record was found
            else
            {
                // return false indicating a problem
                return false;
            }
        }
    }
}