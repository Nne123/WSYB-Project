using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsMenuItemCollection
    {
        List<clsMenuItem> mMenuItemList = new List<clsMenuItem>();

        clsMenuItem mThisMenuItem = new clsMenuItem();

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
                mMenuItemList.Add(AMenuItem);
                Index++;
            }
        }



        public int Count
        {
            get
            {
                return mMenuItemList.Count;
            }
            set
            {
                // worry about later
            }
        }
        public List<clsMenuItem> MenuItemList
        {
            get
            {
                return mMenuItemList;
            }
            set
            {
                mMenuItemList = value;
            }
        }

        public clsMenuItem ThisMenuItem
        {
            get
            {
                return mThisMenuItem;
            }
            set
            {
                mThisMenuItem = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@MenuItem", mThisMenuItem.MenuItem);
            DB.AddParameter("@MenuItemPrice", mThisMenuItem.MenuItemPrice);
            // execute the query returning the primary key value
            return DB.Execute("sproc_tblMenuItem_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@MenuItemNo", mThisMenuItem.MenuItemNo);
            DB.Execute("sproc_tblMenuItem_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@MenuItemNo", mThisMenuItem.MenuItemNo);
            DB.AddParameter("@MenuItem", mThisMenuItem.MenuItem);
            DB.AddParameter("@MenuItemPrice", mThisMenuItem.MenuItemPrice);
            DB.Execute("sproc_tblMenuItem_Update");
        }

    }
}