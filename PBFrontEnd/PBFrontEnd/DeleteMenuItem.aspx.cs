using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class DeleteMenuItem : System.Web.UI.Page
{
    Int32 MenuItemNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the menu item to be deleted from the session object
        MenuItemNo = Convert.ToInt32(Session["MenuItemNo"]);
    }

    void Delete()
    {
        clsMenuItemCollection MenuItemBook = new clsMenuItemCollection();
        MenuItemBook.ThisMenuItem.Find(MenuItemNo);
        MenuItemBook.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        Delete();
        Response.Redirect("MenuDefault.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("MenuDefault.aspx");
    }
}