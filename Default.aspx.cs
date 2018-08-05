using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session.Add("key", "this is session value");
        
    }

    public string formatUrl()
    {
       // int pageId = 1;
        
        return "ViewPost.aspx?pid=";
    }
}