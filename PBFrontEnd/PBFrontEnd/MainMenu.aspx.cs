using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MainMenu : System.Web.UI.Page
{
    //create an instance of the security class with page level scope
    clsSecurity Sec;

    protected void Page_Load(object sender, EventArgs e)
    {
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

    //private void SetLinks(Boolean Authenticated)
    //{
    //    ///sets the visiible state of the links based on the authentication state
    //    ///

    //    //set the state of the following to not authenticated i.e. they will be visible when not logged in
    //    btnOrder.Visible = !Authenticated;

    //    //set the state of the following to authenticated i.e. they will be visible when user is logged in
    //    btnMenu.Visible = Authenticated;
    //    btnStaff.Visible = Authenticated;
    //}


    private void SetLinks(Boolean Authenticated)
    {
        ///sets the visiible state of the links based on the authentication state
        ///
        // if user has not logged in
        if (Authenticated == true)
        {
            // make order button available
            btnOrder.Visible = true;
        }
        // if user has logged in
        if (Authenticated == false)
        {
            // make staff, menu and order available
            btnOrder.Visible = true;
            btnMenu.Visible = false;
            btnStaff.Visible = false;
        }

    }

    // event handler for staff button
    protected void btnStaffMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffDefault.aspx");
    }

    // event handler for menu button
    protected void btnMenuMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("MenuDefault.aspx");
    }

    // event handler for order button
    protected void btnDefaultMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderDefault.aspx");
    }
}