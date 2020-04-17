using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Default : System.Web.UI.Page
{
    clsSecurity Sec;

    protected void Page_Load(object sender, EventArgs e)
    {
        lblError.Text = "";

        if (IsPostBack == false)
        {
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


    void DisplayOrders()
    {
        // create an instance of the order collection
        clsOrderCollection Orders = new clsOrderCollection();
        lstOrders.DataSource = Orders.OrderList;
        lstOrders.DataValueField = "OrderNo";
        lstOrders.DataTextField = "OrderNo";
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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderNo"] = -1;
        Response.Redirect("AnOrder.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // var to store the primary key value of the record to be edited
        Int32 OrderNo;
        // if the record has been selected from the list
        if (lstOrders.SelectedIndex != -1)
        {
            OrderNo = Convert.ToInt32(lstOrders.SelectedValue);
            // store the data in the session object
            Session["OrderNo"] = OrderNo;
            // redirect to the edit page
            Response.Redirect("AnOrder.aspx");
        }
        else
        {
            // display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderNo;

        if (lstOrders.SelectedIndex != -1)
        {
            OrderNo = Convert.ToInt32(lstOrders.SelectedValue);
            // store the data in the session object
            Session["OrderNo"] = OrderNo;
            Response.Redirect("DeleteOrder.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}