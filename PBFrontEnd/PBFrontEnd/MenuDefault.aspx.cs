using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class MenuDefault : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayMenuItems();
        }
    }

    void DisplayMenuItems()
    {
        clsMenuItemCollection MenuItems = new clsMenuItemCollection();
        lstMenuItems.DataSource = MenuItems.MenuItemList;
        lstMenuItems.DataValueField = "MenuItemNo";
        lstMenuItems.DataTextField = "MenuItem";
        lstMenuItems.DataBind();
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // store -1 into the session object to indicate this is a new record
        Session["MenuItemNo"] = -1;
        // redirect to the data entry page
        Response.Redirect("AMenuItem.aspx");
    }
}