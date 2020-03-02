using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrders();
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
}