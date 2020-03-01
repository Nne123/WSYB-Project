using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class MenuDefault : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayMenuItems();
        }
    }

    void DisplayMenuItems()
    {
        clsMenuItemCollection MenuItems = new clsMenuItemCollection();
        lstMenuItems.DataSource = MenuItems.MenuItemList;
        lstMenuItems.DataValueField = "MenuItemNo";
        lstMenuItems.DataTextField = "MenuItem";
        // bind the data to the list
        lstMenuItems.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // store -1 into the session object to indicate this is a new record
        Session["MenuItemNo"] = -1;
        // redirect to the data entry page
        Response.Redirect("AMenuItem.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 MenuItemNo;
        // if a record has been selected from the list
        if (lstMenuItems.SelectedIndex != -1)
        {
            MenuItemNo = Convert.ToInt32(lstMenuItems.SelectedValue);
            Session["MenuItemNo"] = MenuItemNo;
            Response.Redirect("DeleteMenuItem.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

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

    protected void btnApply_Click(object sender, EventArgs e)
    {

    }
}