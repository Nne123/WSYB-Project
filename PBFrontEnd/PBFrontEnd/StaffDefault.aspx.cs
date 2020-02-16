using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffDefault : System.Web.UI.Page
{
    // this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // update the list box
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        ClassLibrary.clsStaffCollection Staff = new ClassLibrary.clsStaffCollection();
        lstStaff.DataSource = Staff.StaffList;
        lstStaff.DataValueField = "StaffNo";
        lstStaff.DataTextField = "StaffLastName";
        // bind the data to the list
        lstStaff.DataBind();
    }
}