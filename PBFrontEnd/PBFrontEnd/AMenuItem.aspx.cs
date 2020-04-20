using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class AMenuItem : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 MenuItemNo;

    //event handler for the page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the menu item to be processed
        MenuItemNo = Convert.ToInt32(Session["MenuItemNo"]);
        if (IsPostBack == false)
        {
            if (MenuItemNo != -1)
            {
                // populate the list of items
                DisplayMenuItem();
            }
        }
    }

    //function for populating the county drop down list
    void DisplayMenuItem()
    {
        //create an instance of the address book
        clsMenuItemCollection MenuItemBook = new clsMenuItemCollection();
        //find the record to update
        MenuItemBook.ThisMenuItem.Find(MenuItemNo);
        //display the data for this record
        txtMenuItem.Text = MenuItemBook.ThisMenuItem.MenuItem;
        txtPrice.Text = MenuItemBook.ThisMenuItem.MenuItemPrice.ToString();
    }

    //function for add
    void Add()
    {
        // create an instance of the menu item class
        clsMenuItemCollection MenuItemBook = new clsMenuItemCollection();
        // validate the data on the web form
        String Error = MenuItemBook.ThisMenuItem.Valid(txtMenuItem.Text , txtPrice.Text);
        // if the data is OK then add it to the object
        if (Error == "")
        {
            // get the data entered by the user
            MenuItemBook.ThisMenuItem.MenuItem = txtMenuItem.Text;
            MenuItemBook.ThisMenuItem.MenuItemPrice = Convert.ToInt32(txtPrice.Text);
            // add the record
            MenuItemBook.Add();
        }
        else
        {
            // report the error
            lblError.Text = "There were too many problems with the data entered " + Error;
        }
    }

    //function for update
    void Update()
    {
        //create an instance of the menu item book
        clsMenuItemCollection MenuItemBook = new clsMenuItemCollection();
        //validate the data on the web form
        String Error = MenuItemBook.ThisMenuItem.Valid(txtMenuItem.Text, txtPrice.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            MenuItemBook.ThisMenuItem.Find(MenuItemNo);
            // get the data entered by the user
            MenuItemBook.ThisMenuItem.MenuItem = txtMenuItem.Text;
            MenuItemBook.ThisMenuItem.MenuItemPrice = Convert.ToInt32(txtPrice.Text);
            //update the record
            MenuItemBook.Update();
            // redirect back to the main page
            Response.Redirect("MenuDefault.aspx");
        }
        else
        {
            // report an error
            lblError.Text = "There were too many problems with the data entered " + Error;
        }
    }

    
    // event handler for OK button
    protected void btnOK_Click(object sender, EventArgs e)
    {
        // if menu item no is new
        if (MenuItemNo == -1)
        {
            // add the record
            Add();
        }
        // otherwise
        else
        {
            // update the record
            Update();
        }

        // redirect to the default page
        Response.Redirect("MenuDefault.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        // redirect to the default page
        Response.Redirect("MenuDefault.aspx");
    }
}