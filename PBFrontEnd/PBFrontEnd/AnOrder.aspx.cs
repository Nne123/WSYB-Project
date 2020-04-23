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

    //event handler for the page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the order to be processed
        OrderNo = Convert.ToInt32(Session["OrderNo"]);
        // if post back is false
        if (IsPostBack == false)
        {
            // populate the list of menu items
            DisplayMenuItems();

            // if this is not a new record
            if (OrderNo != -1)
            {
                // display the current data for the record
                DisplayOrder();
            }
        }
    }

    //function for populating the menu items drop down list
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

    //function for displaying the order in text fields
    void DisplayOrder()
    {
        // create an instance of the order book
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

    //function for adding new records
    void Add()
    {
        // create an instance of the order book
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
            //Response.Redirect("OrderDefault.aspx");
            Response.Redirect("ACardDetails.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }

    }

    //function for updating records
    void Update()
    {
        // create an instance of the class
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
            //all done so redirect back to the main page
            Response.Redirect("OrderDefault.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

   


    //event handler for the ok button
    protected void btnOK_Click(object sender, EventArgs e)
    {

        // if order no does not exist
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

        //Response.Redirect("ACardDetails.aspx");
    }


    //event handler for the cancel button
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        // redirect to the order default page
        Response.Redirect("OrderDefault.aspx");
    }

    protected void ddlThirdMenuItem_SelectedIndexChanged(object sender, EventArgs e)
    {

    }


     // function for retrieve prices
    void RetrievePrices()
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        clsMenuItemCollection MenuBook = new clsMenuItemCollection();

        int currentFirstChoice = Convert.ToInt32(ddlFirstChoice.SelectedValue);       // Stores the MenuItemID
        int currentSecondChoice = Convert.ToInt32(ddlSecondChoice.SelectedValue);
        int currentThirdChoice = Convert.ToInt32(ddlThirdChoice.SelectedValue);

        int currentFirstPrice = MenuBook.ThisMenuItem.MenuItemNo;
        int currentSecondPrice = MenuBook.ThisMenuItem.MenuItemNo;
        int currentThirdPrice = MenuBook.ThisMenuItem.MenuItemNo;


        if (currentFirstChoice == MenuBook.ThisMenuItem.MenuItemNo)
        //if (currentFirstChoice == currentFirstPrice)

            {
            //GetMenuItemPrices();
            currentFirstChoice = MenuBook.ThisMenuItem.MenuItemPrice;
            //currentFirstChoice = currentFirstPrice;

        }
        if (currentSecondChoice == MenuBook.ThisMenuItem.MenuItemNo)
        {
            //GetMenuItemPrices();
            currentSecondChoice = MenuBook.ThisMenuItem.MenuItemPrice;
        }
        if (currentThirdChoice == MenuBook.ThisMenuItem.MenuItemNo)
        {
            //GetMenuItemPrices();
            currentThirdChoice = MenuBook.ThisMenuItem.MenuItemPrice;
        }

        else
        {

        }
        // store the current first choice into the price text boxes
        txtFirstPrice.Text = currentFirstChoice.ToString();
        txtSecondPrice.Text = currentSecondChoice.ToString();
        txtThirdPrice.Text = currentThirdChoice.ToString();
    }


    // function to calcualte 
    void Calculate()
    {
        // copy the data into the variables
        int FirstPrice = Convert.ToInt32(txtFirstPrice.Text);
        int SecondPrice = Convert.ToInt32(txtSecondPrice.Text);
        int ThirdPrice = Convert.ToInt32(txtThirdPrice.Text);

        // find the total
        int Total = (FirstPrice + SecondPrice + ThirdPrice);

        // copy the data into the text box
        txtOrderTotal.Text = Total.ToString("0");
    }

    // function to clear the text boxes
    void ClearTextBoxes()
    {
        // assign the text boxes to empty string
        txtFirstPrice.Text = "";
        txtSecondPrice.Text = "";
        txtThirdPrice.Text = "";
    }

    // event handler for refresh button
    protected void btnRefresh_Click(object sender, EventArgs e)
    {
        // if the textboxes are already filled
        if (txtFirstPrice.Text != "-1" || txtSecondPrice.Text != "-1" || txtThirdPrice.Text != "-1")
        {
            // invoke the clear text boxes method
            ClearTextBoxes();
        }

        // if the text boxes are empty
        if (txtFirstPrice.Text == "" || txtSecondPrice.Text == "" || txtThirdPrice.Text == "")
        {
            // retrieve the prices
            RetrievePrices();
        }
        // otherwise
        else
        {
            //
        }

        // 
        Calculate();

        //UpdateSession();
    }


}