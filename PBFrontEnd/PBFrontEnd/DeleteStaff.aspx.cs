using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;



public partial class DeleteStaff : System.Web.UI.Page
{
    // var to store the primary key value of the record to be deleted
    Int32 StaffNo;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff no to be deleted from the session object
        StaffNo = Convert.ToInt32(Session["StaffNo"]);
    }

    // function to delete the selected record
    void DeleteStaffs()
    {
        // create a new instance of the staff book
        clsStaffCollection StaffBook = new clsStaffCollection();
        // find the record
        StaffBook.ThisStaff.Find(StaffNo);
        // delete the record
        StaffBook.Delete();
    }

    // event handler for the yes button
    protected void btnYes_Click(object sender, EventArgs e)
    {
        // delete the record
        DeleteStaffs();
        // redirect to the main page
        Response.Redirect("StaffDefault.aspx");
    }
}