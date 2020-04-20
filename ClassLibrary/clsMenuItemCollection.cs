using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsMenuItemCollection
    {
        // private data member for the list
        List<clsMenuItem> mAllMenuItems = new List<clsMenuItem>();
        // private data member for this Menu item
        clsMenuItem mThisMenuItem = new clsMenuItem();

        // public constructor for the class
        public clsMenuItemCollection()
        {
            // object for data connection
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblMenuItem_SelectAll");
            // get the count of records
            Int32 RecordCount = DB.Count;
            // set up the index for the loop
            Int32 Index = 0;
            // while there are records to process
            while (Index < RecordCount)
            {
                // create a new instance of the menu class
                clsMenuItem AMenuItem = new clsMenuItem();
                // get the menu item price
                AMenuItem.MenuItemPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["MenuItemPrice"]);
                // get the menu item
                AMenuItem.MenuItem = DB.DataTable.Rows[Index]["MenuItem"].ToString();
                // get the menu item no
                AMenuItem.MenuItemNo = Convert.ToInt32(DB.DataTable.Rows[Index]["MenuItemNo"]);
                mAllMenuItems.Add(AMenuItem);
                Index++;
            }
        }

        public void ReportByMenuItem(string MenuItem)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@MenuItem", MenuItem);
            DB.Execute("sproc_tblMenuItem_FilterByMenuItem");
            PopulateArray(DB);
        }

        void PopulateArray (clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mAllMenuItems = new List<clsMenuItem>();
            while (Index < RecordCount)
            {
                clsMenuItem AMenuItem = new clsMenuItem();
                AMenuItem.MenuItem = Convert.ToString(DB.DataTable.Rows[Index]["MenuItem"]);
                AMenuItem.MenuItemNo = Convert.ToInt32(DB.DataTable.Rows[Index]["MenuItemNo"]);
                AMenuItem.MenuItemPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["MenuItemPrice"]);

                mAllMenuItems.Add(AMenuItem);

                Index++;
            }
        }












        public int Count
        {
            get
            {
                return mAllMenuItems.Count;
            }
            set
            {
                // worry about later
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