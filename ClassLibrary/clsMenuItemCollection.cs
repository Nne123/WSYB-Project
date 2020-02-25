using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsMenuItemCollection
    {
        // public constructor for the class
        public clsMenuItemCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblMenuItem_SelectAll");
            Int32 RecordCount = DB.Count;
            Int32 Index = 0;
            while (Index < RecordCount)
            {
                clsMenuItem AMenuItem = new clsMenuItem();
                AMenuItem.MenuItem = DB.DataTable.Rows[Index]["MenuItem"].ToString();
                AMenuItem.MenuItemPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["MenuItemPrice"]);
                mAllMenuItems.Add(AMenuItem);
                Index++;
            }


            //clsMenuItem AMenuItem = new clsMenuItem();
            //AMenuItem.MenuItem = "Carrot";
            //AMenuItem.MenuItemPrice = 6;
            //mAllMenuItems.Add(AMenuItem);
            //AMenuItem.MenuItem = "Peach";
            //AMenuItem.MenuItemPrice = 2;
            //mAllMenuItems.Add(AMenuItem);
            //// list now contains two menu items
        }






        private List<clsMenuItem> mAllMenuItems = new List<clsMenuItem>();

        public int Count
        {
            get
            {
                return mAllMenuItems.Count;
            }
            set
            {
                
            }
        }
        public List<clsMenuItem> AllMenuItems
        {
            get
            {
                return mAllMenuItems;
            }
            set
            {
                mAllMenuItems = value;
            }
        }
    }
}