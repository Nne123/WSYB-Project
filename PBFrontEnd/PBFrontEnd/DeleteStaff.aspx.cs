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

    protected void Page_Load(object sender, EventArgs e)
    {
        StaffNo = Convert.ToInt32(Session["StaffNo"]);
    }

    void DeleteStaffs()
    {
        // function to delete the selected record

        // create a new instance of the staff book
        clsStaffCollection StaffBook = new clsStaffCollection();
        StaffBook.ThisStaff.Find(StaffNo);
        StaffBook.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        DeleteStaffs();
        Response.Redirect("StaffDefault.aspx");
    }
}