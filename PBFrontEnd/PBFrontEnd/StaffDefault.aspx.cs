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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StaffNo"] = -1;
        Response.Redirect("AStaff.aspx");
    }

    // event handler for the delete button
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // var to store the primary key value of the record to be deleted
        Int32 StaffNo;
        // if a record has been selected from the list
        if (lstStaff.SelectedIndex != -1)
        {
            // get the primary key value of the record to delete
            StaffNo = Convert.ToInt32(lstStaff.SelectedValue);
            Session["StaffNo"] = StaffNo;
            Response.Redirect("DeleteStaff.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // var to store the primary key value of the record to be edited
        Int32 StaffNo;
        // if a record has been selected from the list
        if (lstStaff.SelectedIndex != -1)
        {
            StaffNo = Convert.ToInt32(lstStaff.SelectedValue);
            Session["StaffNo"] = StaffNo;
            Response.Redirect("AStaff.aspx");
        }
        else
        {
            lblError.Text = "Please selected a record to update from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        
        //assign the results of the DisplayAppointments function to the record count var
        //DisplayStaff(txtLastName.Text);
        
    }
}