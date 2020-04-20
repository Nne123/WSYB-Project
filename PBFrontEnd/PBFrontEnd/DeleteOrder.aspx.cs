using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class DeleteOrder : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 OrderNo;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be deleted from the session object
        OrderNo = Convert.ToInt32(Session["OrderNo"]);
    }

    // function for delete
    void Delete()
    {
        // create an instance of the class
        clsOrderCollection OrderBook = new clsOrderCollection();
        // find the record to delete
        OrderBook.ThisOrder.Find(OrderNo);
        // delete the record
        OrderBook.Delete();
    }

    //event handler for the yes button
    protected void btnYes_Click(object sender, EventArgs e)
    {
        // delete the record
        Delete();
        // redirect to the main page
        Response.Redirect("OrderDefault.aspx");
    }

    //event handler for the no button
    protected void btnNo_Click(object sender, EventArgs e)
    {
        // redirect to the main page
        Response.Redirect("OrderDefault.aspx");
    }
}