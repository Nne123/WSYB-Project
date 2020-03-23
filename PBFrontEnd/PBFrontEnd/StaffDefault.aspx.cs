using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class StaffDefault : System.Web.UI.Page
{
    // this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        // clear any existing error messages
        lblError.Text = "";

        // if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // update the list box
            lblError.Text = DisplayStaff("") + " records in the database ";
        }
    }

    Int32 DisplayStaff(string LastNameFilter)
    {
        clsStaffCollection MyStaffBook = new clsStaffCollection();
        Int32 RecordCount;
        string FirstName;
        string LastName;
        string PostCode;
        string StaffNo;
        Int32 Index = 0;
        lstStaff.Items.Clear();
        MyStaffBook.ReportByLastName(LastNameFilter);
        RecordCount = MyStaffBook.Count;
        while (Index < RecordCount)
        {
            FirstName = Convert.ToString(MyStaffBook.StaffList[Index].StaffFirstName);
            LastName = Convert.ToString(MyStaffBook.StaffList[Index].StaffLastName);
            PostCode = Convert.ToString(MyStaffBook.StaffList[Index].PostCode);
            StaffNo = Convert.ToString(MyStaffBook.StaffList[Index].StaffNo);

            // set up a new object of the class list item

            ListItem NewItem = new ListItem(LastName + " ", StaffNo);

            lstStaff.Items.Add(NewItem);

            Index++;

        }

        return RecordCount;

        //clsStaffCollection Staff = new clsStaffCollection();
        //lstStaff.DataSource = Staff.StaffList;
        //lstStaff.DataValueField = "StaffNo";
        //lstStaff.DataTextField = "StaffLastName";
        //// bind the data to the list
        //lstStaff.DataBind();
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
        Int32 RecordCount;
        RecordCount = DisplayStaff(txtLastName.Text);
        lblError.Text = RecordCount + " records found";

    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        // var to store the record count
        Int32 RecordCount;
        // assign the results of the DisplayStaff function to record the count var
        RecordCount = DisplayStaff("");
        //display the number of records found
        lblError.Text = RecordCount + " records found in the database";
        // clear the post code filter text box
        txtLastName.Text = "";
    }
}