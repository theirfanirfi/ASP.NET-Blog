using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CustomForm;
using System.Data.SqlClient;
using System.Data;

public partial class AddPost : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Irfan Ullah\Documents\Visual Studio 2012\WebSites\MyBlog\App_Data\blog_db.mdf;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
   
        if (1)
        {
            string v = Session["key"].ToString();
            Response.Write("<script>alert('" + v + "');</script>");
            Session.RemoveAll();
        }
        else
        {
            Response.Write("<script>alert('value is null');</script>");
        }
       // GhostForm mainForm = new GhostForm();
        //mainForm.RenderFormTag = false;
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String title = post_title.Text;
        String Description = texarea.Text;
       

        try
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                String query = "INSERT INTO posts(post_title,post_description) VALUES('" + title + "','" + Description + "')";
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
                Response.Write("<script>alert('Post Published');</script>");
                Response.Redirect("Default.aspx");

            }
            else
            {
                Response.Write("<script>alert('Error not close');</script>");
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex.ToString() + "');</script>");
        }
        finally
        {
            con.Close();
        }
        
        
    }
}