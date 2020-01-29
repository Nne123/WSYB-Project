using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsMenuItemCollection
    {
        private List<clsMenuItem> mAllMenuItems = new List<clsMenuItem>();

        public int Count
        {
            get
            {
                return mAllMenuItems.Count;
            }
            set
            {
                //;
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

        public clsMenuItemCollection()
        {
            clsMenuItem AMenuItem = new clsMenuItem();
            AMenuItem.MenuItem = "Strawberry";
            mAllMenuItems.Add(AMenuItem);
            AMenuItem = new clsMenuItem();
            AMenuItem.MenuItem = "Mango";
            mAllMenuItems.Add(AMenuItem);
            // private list now contains two counties
        }
    }
}