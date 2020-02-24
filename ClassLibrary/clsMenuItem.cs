using System;

namespace ClassLibrary
{
    public class clsMenuItem
    {
        private Int32 mMenuItemNo;
        private string mMenuItem;
        private Int32 mMenuItemPrice;

        public string MenuItem
        {
            get
            {
                return mMenuItem;
            }
            set
            {
                mMenuItem = value;
            }
        }
        public int MenuItemNo
        {
            get
            {
                return mMenuItemNo;
            }
            set
            {
                mMenuItemNo = value;
            }
        }
        public int MenuItemPrice
        {
            get
            {
                return mMenuItemPrice;
            }
            set
            {
                mMenuItemPrice = value;
            }
        }

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

        public bool Find(int menuItemNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@MenuItemNo", menuItemNo);
            DB.Execute("sproc_tblMenuItem_FilterByMenuItemNo");
            if (DB.Count == 1)
            {
                mMenuItemNo = Convert.ToInt32(DB.DataTable.Rows[0]["MenuItemNo"]);
                mMenuItem = Convert.ToString(DB.DataTable.Rows[0]["MenuItem"]);
                mMenuItemPrice = Convert.ToInt32(DB.DataTable.Rows[0]["MenuItemPrice"]);
                // return that everything worked OK
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}