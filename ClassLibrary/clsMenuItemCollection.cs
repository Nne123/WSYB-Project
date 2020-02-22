using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsMenuItemCollection
    {
        // private data member for the list
        List<clsMenuItem> mMenuItemList = new List<clsMenuItem>();

        // constructor for the class
        public clsMenuItemCollection()
        {
            clsMenuItem TestMenuItem = new clsMenuItem();
            TestMenuItem.MenuItemNo = 1;
            TestMenuItem.MenuItem = "Strawberry";
            TestMenuItem.MenuItemPrice = 4;
            // add the item to the test list
            mMenuItemList.Add(TestMenuItem);
            // re initialise the object for some new data
            TestMenuItem = new clsMenuItem();
            // set its properties
            TestMenuItem.MenuItemNo = 2;
            TestMenuItem.MenuItem = "Mango";
            TestMenuItem.MenuItemPrice = 5;
            // add the item to the list
            mMenuItemList.Add(TestMenuItem);
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
        public int Count
        {
            get
            {
                return mMenuItemList.Count;
            }
            set
            {
                // return to this later
            }
        }
        public clsMenuItem ThisMenuItem { get; set; }
    }
}