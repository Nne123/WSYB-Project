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

    // function for display staff
    Int32 DisplayStaff(string LastNameFilter)
    {
        // create an instance of the class
        clsStaffCollection MyStaffBook = new clsStaffCollection();
        // var to store the Record count
        Int32 RecordCount;
        // var to store the first name
        string FirstName;
        // var to store the last name
        string LastName;
        // var to store the post code
        string PostCode;
        // var to store the staff no
        string StaffNo;
        // initialise the index at 0
        Int32 Index = 0;
        // clear the list
        lstStaff.Items.Clear();
        // filter the staff list by the last name methor
        MyStaffBook.ReportByLastName(LastNameFilter);
        // get the count of records
        RecordCount = MyStaffBook.Count;
        // while index is less than record count
        while (Index < RecordCount)
        {
            // store the staff name
            FirstName = Convert.ToString(MyStaffBook.StaffList[Index].StaffFirstName);
            LastName = Convert.ToString(MyStaffBook.StaffList[Index].StaffLastName);
            PostCode = Convert.ToString(MyStaffBook.StaffList[Index].PostCode);
            StaffNo = Convert.ToString(MyStaffBook.StaffList[Index].StaffNo);

            // set up a new object of the class list item
            ListItem NewItem = new ListItem(LastName + " " + " " + PostCode, StaffNo);
            // add the new item to the list
            lstStaff.Items.Add(NewItem);
            // increment the index
            Index++;

        }
        // return the number of records
        return RecordCount;
    }

    // event handler for add
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StaffNo"] = -1;
        //redirect to the data entry page
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
            //store the data in the session object
            Session["StaffNo"] = StaffNo;
            //redirect to the delete page
            Response.Redirect("DeleteStaff.aspx");
        }
        // otherwise
        else
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    //event handler for the edit button
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // var to store the primary key value of the record to be edited
        Int32 StaffNo;
        // if a record has been selected from the list
        if (lstStaff.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StaffNo = Convert.ToInt32(lstStaff.SelectedValue);
            //store the data in the session object
            Session["StaffNo"] = StaffNo;
            //redirect to the edit page
            Response.Redirect("AStaff.aspx");
        }
        // otherwise
        else
        {
            // display an error message
            lblError.Text = "Please selected a record to update from the list";
        }
    }

    //event handler for the apply button
    protected void btnApply_Click(object sender, EventArgs e)
    {

        // declare var to store the record count
        Int32 RecordCount;
        //assign the results of the DisplayAddresses function to the record count var
        RecordCount = DisplayStaff(txtLastName.Text);
        //display the number of records found
        lblError.Text = RecordCount + " records found";

    }

    //event hanlder for the display all button
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