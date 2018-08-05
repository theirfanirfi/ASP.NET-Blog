using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class ViewPost : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Irfan Ullah\Documents\Visual Studio 2012\WebSites\MyBlog\App_Data\blog_db.mdf;Integrated Security=True");
   
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
         string pid = Request.QueryString["id"];
        String query = "SELECT * FROM posts WHERE Id = '"+pid+"'";
       // SqlCommand com = new SqlCommand(query, con);
        SqlDataAdapter da = new SqlDataAdapter(query, con);
        DataSet ds = new DataSet();
        da.Fill(ds);

        DataList1.DataSource = ds;
        DataList1.DataBind();
        con.Close();
       

        //Response.Write("<script>alert('" + pid + "');</script>");
    }
    protected void DataList1_DeleteCommand(object source, DataListCommandEventArgs e)
    {

    }
}