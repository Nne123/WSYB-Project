using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayCounties();
        }
    }

    void DisplayCounties()
    {
        //create an instance of the County Collection
        ClassLibrary.clsCountyCollection Counties = new ClassLibrary.clsCountyCollection();
        //set the data source to the list of counties in the collection
        ddlCounty.DataSource = Counties.AllCounties;
        //set the name of the primary key
        ddlCounty.DataValueField = "CountyNo";
        //set the data field to display
        ddlCounty.DataTextField = "County";
        //bind the data to the list
        ddlCounty.DataBind();
    }
}