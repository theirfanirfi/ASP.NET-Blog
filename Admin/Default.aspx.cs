using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void updateRowRecord(object sender, GridViewUpdatedEventArgs e)
    {
        Response.Write("<script>alert('Record Updated Successfully.');</script>");
    }
    protected void SqlDataSource1_Updating(object sender, SqlDataSourceCommandEventArgs e)
    {
        Response.Write("<script>confirm('Do you want to add Update the current Row?');</script>");

    }

    protected void btnAddRow_Click(object sender, EventArgs e)
    {
        Response.Redirect("../AddPost.aspx");
    }
}