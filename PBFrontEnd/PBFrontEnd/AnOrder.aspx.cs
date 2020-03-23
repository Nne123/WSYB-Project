using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class AnOrder : System.Web.UI.Page
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
        // set the primary key to the list of menu items in the collection
        ddlFirstMenuItem.DataSource = MenuItems.AllMenuItems;
        ddlSecondMenuItem.DataSource = MenuItems.AllMenuItems;
        ddlThirdMenuItem.DataSource = MenuItems.AllMenuItems;
        // set the name of the primary key
        ddlFirstMenuItem.DataValueField = "MenuItemNo";
        ddlSecondMenuItem.DataValueField = "MenuItemNo";
        ddlThirdMenuItem.DataValueField = "MenuItemNo";
        // set the data value field to display
        ddlFirstMenuItem.DataTextField = "MenuItem";
        ddlSecondMenuItem.DataTextField = "MenuItem";
        ddlThirdMenuItem.DataTextField = "MenuItem";
        // bind the data to the list
        ddlFirstMenuItem.DataBind();
        ddlSecondMenuItem.DataBind();
        ddlThirdMenuItem.DataBind();

        //lblFirstPrice.ToString = "FirstChoice";
        //Convert.ToString(lblFirstPrice.Text);

        lblFirstPrice.DataBind();
        lblSecondPrice.DataBind();
        lblThirdPrice.DataBind();
    }

    void Add()
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        // validate the data on the web form
        String Error = OrderBook.ThisOrder.Valid();
        // if the data is OK then add it to the object
        if (Error == "")
        {
            OrderBook.ThisOrder.FirstMenuItem = Convert.ToInt32(ddlFirstMenuItem.SelectedValue);
            OrderBook.ThisOrder.SecondMenuItem = Convert.ToInt32(ddlSecondMenuItem.SelectedValue);
            OrderBook.ThisOrder.ThirdMenuItem = Convert.ToInt32(ddlThirdMenuItem.SelectedValue);

            //if  ( OrderBook.ThisOrder.F)

            //OrderBook.ThisOrder.FirstPrice = Convert.ToInt32(ddlFirstMenuItem.Text);

            //OrderBook.ThisOrder.FirstPrice = Convert.ToInt32(lblFirstPrice);
            //OrderBook.ThisOrder.SecondPrice = Convert.ToInt32(lblSecondPrice);
            //OrderBook.ThisOrder.ThirdPrice = Convert.ToInt32(lblThirdPrice);
            //OrderBook.ThisOrder.OrderTotal = Convert.ToInt32(lblOrderTotal);
            // add the record
            OrderBook.Add();
        }
        else
        {
            lblError.Text = "There were problems with the data entered " + Error;
        }

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        Add();
        Response.Redirect("OrderDefault.aspx");
    }
}