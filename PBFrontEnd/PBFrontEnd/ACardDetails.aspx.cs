using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class CardDetailsDefault : System.Web.UI.Page
{
    // this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //
        }
    }


    //function for adding new records
    void Add()
    {
        // create an instance of the order book
        clsCardDetailsCollection CardDetailsBook = new clsCardDetailsCollection();
        // validate the data on the web form
        String Error = CardDetailsBook.ThisCardDetails.Valid(txtCardNo1.Text);
        // if the data is OK then add it to the object
        if (Error == "")
        {
            CardDetailsBook.ThisCardDetails.CardNo1 = Convert.ToString(txtCardNo1.Text);
            // add the record
            CardDetailsBook.Add();
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        Add();
        Response.Redirect("OrderDefault.aspx");
    }
}