using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class AStaff : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 StaffNo;

    //event handler for the page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff to be processed
        StaffNo = Convert.ToInt32(Session["StaffNo"]);
        if (IsPostBack == false)
        {
            //populate the list of counties
            DisplayCounties();
            // if this is not a new record
            if (StaffNo != -1)
            {
                // display the current data for the record
                DisplayStaff();
            }
        }
    }

    //function for populating the county drop down list
    void DisplayCounties()
    {
        //create an instance of the County Collection
        clsCountyCollection Counties = new clsCountyCollection();
        //set the data source to the list of counties in the collection
        ddlCounty.DataSource = Counties.AllCounties;
        //set the name of the primary key
        ddlCounty.DataValueField = "CountyNo";
        //set the data field to display
        ddlCounty.DataTextField = "County";
        //bind the data to the list
        ddlCounty.DataBind();
    }

    // function for add
    void Add()
    {
        //create an instance of the class
        clsStaffCollection StaffBook = new clsStaffCollection();
        // validate the data on the web form
        String Error = StaffBook.ThisStaff.Valid(txtFirstName.Text, txtLastName.Text, txtAddressLine.Text, txtPostCode.Text, txtPhoneNo.Text);
        // if the data is OK then add it to the object
        if (Error == "")
        {
            // get the data entered by the user
            StaffBook.ThisStaff.StaffFirstName = txtFirstName.Text;
            StaffBook.ThisStaff.StaffLastName = txtLastName.Text;
            StaffBook.ThisStaff.AddressLine = txtAddressLine.Text;
            StaffBook.ThisStaff.PostCode = txtPostCode.Text;
            StaffBook.ThisStaff.PhoneNo = txtPhoneNo.Text;
            StaffBook.ThisStaff.CountyNo = Convert.ToInt32(ddlCounty.SelectedValue);
            StaffBook.ThisStaff.Active = chkActive.Checked;
            // add the record
            StaffBook.Add();
        }
        else
        {
            // report the error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    //event handler for the OK button
    protected void btnOK_Click(object sender, EventArgs e)
    {
        // if staff no is new
        if (StaffNo == -1)
        {
            Add();
        }
        // otherwise
        else
        {
            // update the record
            Update();
        }

        //redirect to the main page
        Response.Redirect("StaffDefault.aspx");
    }

    // function for update
    void Update()
    {
        //create an instance of the staff Collection
        clsStaffCollection StaffBook = new clsStaffCollection();
        // validate the data on the web form
        String Error = StaffBook.ThisStaff.Valid(txtFirstName.Text, txtLastName.Text, txtAddressLine.Text, txtPostCode.Text, txtPhoneNo.Text);
        // if the data is OK then add it to the object
        if (Error == "")
        {
            // find the record to update
            StaffBook.ThisStaff.Find(StaffNo);
            // get the data entered by the user
            StaffBook.ThisStaff.StaffFirstName = txtFirstName.Text;
            StaffBook.ThisStaff.StaffLastName = txtLastName.Text;
            StaffBook.ThisStaff.AddressLine = txtAddressLine.Text;
            StaffBook.ThisStaff.PostCode = txtPostCode.Text;
            StaffBook.ThisStaff.PhoneNo = txtPhoneNo.Text;
            StaffBook.ThisStaff.CountyNo = Convert.ToInt32(ddlCounty.SelectedValue);
            StaffBook.ThisStaff.Active = chkActive.Checked;
            // update the record
            StaffBook.Update();
            // all done so redirect back to the main page
            Response.Redirect("StaffDefault.aspx");
        }
        else
        {
            // report the error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    // function for display staff
    void DisplayStaff()
    {
        // create an instance of the staff book
        clsStaffCollection StaffBook = new clsStaffCollection();
        // find the record to update
        StaffBook.ThisStaff.Find(StaffNo);
        // display the data for this record
        txtFirstName.Text = StaffBook.ThisStaff.StaffFirstName;
        txtLastName.Text = StaffBook.ThisStaff.StaffLastName;
        txtAddressLine.Text = StaffBook.ThisStaff.AddressLine;
        txtPostCode.Text = StaffBook.ThisStaff.PostCode;
        txtPhoneNo.Text = StaffBook.ThisStaff.PhoneNo;
        chkActive.Checked = StaffBook.ThisStaff.Active;
        ddlCounty.SelectedValue = StaffBook.ThisStaff.CountyNo.ToString();
    }

    // event handler for the cancel button
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffDefault.aspx");
    }
}