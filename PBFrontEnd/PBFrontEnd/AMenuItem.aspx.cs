using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class AMenuItem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    void Add()
    {
        clsMenuItemCollection MenuItemBook = new clsMenuItemCollection();
        String Error = MenuItemBook.ThisMenuItem.Valid(txtMenuItem.Text, txtPrice.Text);
        if (Error == "")
        {
            MenuItemBook.ThisMenuItem.MenuItem = txtMenuItem.Text;
            MenuItemBook.ThisMenuItem.MenuItemPrice = Convert.ToInt32(txtPrice.Text);
            MenuItemBook.Add();
        }
        else
        {
            lblError.Text = "There were too many problems with the data entered " + Error;
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        Add();
        Response.Redirect("MenuDefault.aspx");
    }
}