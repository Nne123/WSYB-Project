using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class MenuDefault : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //clear any existing error messages
        lblError.Text = "";
        //if this is the first time the page has been displayed
        if (IsPostBack == false)
        {
            // list the records in the database
            lblError.Text = DisplayMenuItems("") + " records in the database ";
        }
    }

    // function to filter records in the list
    Int32 DisplayMenuItems(string MenuItemFilter)
    {
        // create an instance of menu item book
        clsMenuItemCollection MyMenuItemBook = new clsMenuItemCollection();
        // var for record count
        Int32 RecordCount;
        // var for menu item
        string MenuItem;
        // var for menu item price
        string MenuItemPrice;
        // var for menu item no
        string MenuItemNo;
        // var for index to start at 0
        Int32 Index = 0;
        // clear the list box
        lstMenuItems.Items.Clear();
        // call the filter by menu item method
        MyMenuItemBook.ReportByMenuItem(MenuItemFilter);
        // store the count of records found
        RecordCount = MyMenuItemBook.Count;
        // while index is less than record count
        //loop through each record found using the index to point to each 
        //record in the data table
        while (Index < RecordCount)
        {
            // get the menu item from the query results
            MenuItem = Convert.ToString(MyMenuItemBook.AllMenuItems[Index].MenuItem);
            // get the menu item price from the query results
            MenuItemPrice = Convert.ToString(MyMenuItemBook.AllMenuItems[Index].MenuItemPrice);
            // get the menu item no from the query results
            MenuItemNo = Convert.ToString(MyMenuItemBook.AllMenuItems[Index].MenuItemNo);
            //set up a new object of class list item 
            ListItem NewItem = new ListItem(MenuItem + " ", MenuItemNo);
            //add the new item to the list
            lstMenuItems.Items.Add(NewItem);
            // increment the index
            Index++;
        }
        //return the number of records found
        return RecordCount;

        //clsMenuItemCollection MenuItems = new clsMenuItemCollection();
        //lstMenuItems.DataSource = MenuItems.AllMenuItems;
        //lstMenuItems.DataValueField = "MenuItemNo";
        //lstMenuItems.DataTextField = "MenuItem";
        //// bind the data to the list
        //lstMenuItems.DataBind();
    }

    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // store -1 into the session object to indicate this is a new record
        Session["MenuItemNo"] = -1;
        // redirect to the data entry page
        Response.Redirect("AMenuItem.aspx");
    }

    //event handler for the delete button
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 MenuItemNo;
        // if a record has been selected from the list
        if (lstMenuItems.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            MenuItemNo = Convert.ToInt32(lstMenuItems.SelectedValue);
            // store the data to the sessin object
            Session["MenuItemNo"] = MenuItemNo;
            // redirect to the delete page
            Response.Redirect("DeleteMenuItem.aspx");
        }
        // otherwise
        else
        {
            // display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    //event handler for the edit button
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 MenuItemNo;
        //if a record has been selected from the list
        if (lstMenuItems.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            MenuItemNo = Convert.ToInt32(lstMenuItems.SelectedValue);
            //store the data in the session object
            Session["MenuItemNo"] = MenuItemNo;
            //redirect to the edit page
            Response.Redirect("AMenuItem.aspx");
        }
        else//if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    // event handler for the apply button
    protected void btnApply_Click(object sender, EventArgs e)
    {
        // var to store the record count
        Int32 RecordCount;
        //assign the results of the DisplayMenuItems function to the record count var
        RecordCount = DisplayMenuItems(txtMenuItem.Text);
        // display the number of records found
        lblError.Text = RecordCount + " records found";
    }

    // event handler for the display all button
    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        // var to store the record count
        Int32 RecordCount;
        // assign the results of the DisplayStaff function to record the count var
        RecordCount = DisplayMenuItems("");
        //display the number of records found
        lblError.Text = RecordCount + " records found in the database";
        // clear the post code filter text box
        txtMenuItem.Text = "";
    }
}