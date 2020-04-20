using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class DeleteMenuItem : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 MenuItemNo;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the menu item to be deleted from the session object
        MenuItemNo = Convert.ToInt32(Session["MenuItemNo"]);
    }

    //function to delete the selected record
    void Delete()
    {
        // create a new instance of the menu book 
        clsMenuItemCollection MenuItemBook = new clsMenuItemCollection();
        // find the record to delete
        MenuItemBook.ThisMenuItem.Find(MenuItemNo);
        // delete the record
        MenuItemBook.Delete();
    }

    //event handler for the yes button
    protected void btnYes_Click(object sender, EventArgs e)
    {
        Delete();
        Response.Redirect("MenuDefault.aspx");
    }

    //event handler for the no button
    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("MenuDefault.aspx");
    }
}