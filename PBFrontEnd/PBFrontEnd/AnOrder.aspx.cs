using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class AnOrder : System.Web.UI.Page
{
    // variable to store the key with page level scope
    Int32 OrderNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the order to be processed
        OrderNo = Convert.ToInt32(Session["OrderNo"]);
        if (IsPostBack == false)
        {
            DisplayMenuItems();

            // if this is not a new record
            if (OrderNo != -1)
            {
                // display the current data for the record
                DisplayOrder();
            }
        }
    }

    void DisplayMenuItems()
    {
        clsMenuItemCollection MenuItems = new clsMenuItemCollection();
        // set the primary key to the list of menu items in the collection
        ddlFirstChoice.DataSource = MenuItems.AllMenuItems;
        ddlSecondChoice.DataSource = MenuItems.AllMenuItems;
        ddlThirdChoice.DataSource = MenuItems.AllMenuItems;
        // set the name of the primary key
        ddlFirstChoice.DataValueField = "MenuItemNo";
        ddlSecondChoice.DataValueField = "MenuItemNo";
        ddlThirdChoice.DataValueField = "MenuItemNo";
        // set the data value field to display
        ddlFirstChoice.DataTextField = "MenuItem";
        ddlSecondChoice.DataTextField = "MenuItem";
        ddlThirdChoice.DataTextField = "MenuItem";
        // bind the data to the list
        ddlFirstChoice.DataBind();
        ddlSecondChoice.DataBind();
        ddlThirdChoice.DataBind();
    }

    void DisplayOrder()
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        // find the record to update
        OrderBook.ThisOrder.Find(OrderNo);
        // display the data for this record
        ddlFirstChoice.Text = OrderBook.ThisOrder.FirstChoice.ToString();
        ddlSecondChoice.Text = OrderBook.ThisOrder.SecondChoice.ToString();
        ddlThirdChoice.Text = OrderBook.ThisOrder.ThirdChoice.ToString();
        txtFirstPrice.Text = OrderBook.ThisOrder.FirstPrice.ToString();
        txtSecondPrice.Text = OrderBook.ThisOrder.SecondPrice.ToString();
        txtThirdPrice.Text = OrderBook.ThisOrder.ThirdPrice.ToString();
        txtOrderTotal.Text = OrderBook.ThisOrder.OrderTotal.ToString();
        



    }

    void Add()
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        // validate the data on the web form
        String Error = OrderBook.ThisOrder.Valid(txtFirstPrice.Text, txtSecondPrice.Text, txtThirdPrice.Text, txtOrderTotal.Text);
        // if the data is OK then add it to the object
        if (Error == "")
        {
            OrderBook.ThisOrder.FirstChoice = Convert.ToInt32(ddlFirstChoice.SelectedValue);
            OrderBook.ThisOrder.SecondChoice = Convert.ToInt32(ddlSecondChoice.SelectedValue);
            OrderBook.ThisOrder.ThirdChoice = Convert.ToInt32(ddlThirdChoice.SelectedValue);

            OrderBook.ThisOrder.FirstPrice = Convert.ToInt32(txtFirstPrice.Text);
            OrderBook.ThisOrder.SecondPrice = Convert.ToInt32(txtSecondPrice.Text);
            OrderBook.ThisOrder.ThirdPrice = Convert.ToInt32(txtThirdPrice.Text);
            OrderBook.ThisOrder.OrderTotal = Convert.ToInt32(txtOrderTotal.Text);
            // add the record
            OrderBook.Add();
        }
        else
        {
            lblError.Text = "There were problems with the data entered " + Error;
        }

    }

    void Update()
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        // validate the data on the web form
        String Error = OrderBook.ThisOrder.Valid(txtFirstPrice.Text, txtSecondPrice.Text, txtThirdPrice.Text, txtOrderTotal.Text);
        // if the data is OK then add it to the object
        if (Error == "")
        {
            // find the record to update
            OrderBook.ThisOrder.Find(OrderNo);
            // get the data entered by the user
            OrderBook.ThisOrder.FirstChoice = Convert.ToInt32(ddlFirstChoice.SelectedValue);
            OrderBook.ThisOrder.SecondChoice = Convert.ToInt32(ddlSecondChoice.SelectedValue);
            OrderBook.ThisOrder.ThirdChoice = Convert.ToInt32(ddlThirdChoice.SelectedValue);

            OrderBook.ThisOrder.FirstPrice = Convert.ToInt32(txtFirstPrice.Text);
            OrderBook.ThisOrder.SecondPrice = Convert.ToInt32(txtSecondPrice.Text);
            OrderBook.ThisOrder.ThirdPrice = Convert.ToInt32(txtThirdPrice.Text);
            OrderBook.ThisOrder.OrderTotal = Convert.ToInt32(txtOrderTotal.Text);
            // update the record
            OrderBook.Update();

            Response.Redirect("OrderDefault.aspx");
        }
        else
        {
            lblError.Text = "There were problems with the data entered " + Error;
        }

    }






    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (OrderNo == -1)
        {
            // add the record
            Add();
        }
        else
        {
            // update the record
            Update();
        }
        
        Response.Redirect("OrderDefault.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderDefault.aspx");
    }

    protected void ddlThirdMenuItem_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}