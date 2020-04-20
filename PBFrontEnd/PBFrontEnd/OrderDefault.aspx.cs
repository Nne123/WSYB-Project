using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Default : System.Web.UI.Page
{
    //create an instance of the security class with page level scope
    clsSecurity Sec;

    // event handler for the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        // clear any existing error messages
        lblError.Text = "";
        // if this is the first time the page has been displayed
        if (IsPostBack == false)
        {
            // populate the list
            DisplayOrders();
        }


        //on load get the current state from the session
        Sec = (clsSecurity)Session["Sec"];
        //if the object is null then it needs initialising
        if (Sec == null)
        {
            //initialise the object
            Sec = new clsSecurity();
            //update the session
            Session["Sec"] = Sec;
        }
        //set the state of the linsk based on the cureent state of authentication
        SetLinks(Sec.Authenticated);

    }

    // private function for setting the status of the links
    private void SetLinks(Boolean Authenticated)
    {
        ///sets the visiible state of the links based on the authentication state
        ///
        // if user has not logged in
        if (Authenticated == true)
        {
            // make order button available
            btnAdd.Visible = true;
        }
        // if user has logged in
        if (Authenticated == false)
        {
            // make staff, menu and order available
            btnAdd.Visible = true;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
        }

    }

    // function for display orders
    void DisplayOrders()
    {
        // create an instance of the order collection
        clsOrderCollection Orders = new clsOrderCollection();
        //set the data source to the list of orders in the collection
        lstOrders.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrders.DataValueField = "OrderNo";
        //set the data field to display
        lstOrders.DataTextField = "OrderNo";
        //bind the data to the list
        lstOrders.DataBind();
    }

    protected void btnSignUp_Click(object sender, EventArgs e)
    {

    }



    protected void btnApply_Click(object sender, EventArgs e)
    {

    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {

    }

    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OrderNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("AnOrder.aspx");
    }

    //event handler for the edit button
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // var to store the primary key value of the record to be edited
        Int32 OrderNo;
        // if the record has been selected from the list
        if (lstOrders.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            OrderNo = Convert.ToInt32(lstOrders.SelectedValue);
            // store the data in the session object
            Session["OrderNo"] = OrderNo;
            // redirect to the edit page
            Response.Redirect("AnOrder.aspx");
        }
        // otherwise
        else
        {
            // display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    //event handler for the delete button
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 OrderNo;

        //if a record has been selected from the list
        if (lstOrders.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            OrderNo = Convert.ToInt32(lstOrders.SelectedValue);
            // store the data in the session object
            Session["OrderNo"] = OrderNo;
            Response.Redirect("DeleteOrder.aspx");
        }
        // otherwise
        else
        {
            // display an error message
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}