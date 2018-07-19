using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            welcome();
        }

    }

    private void welcome()
    {
        if (Request.Cookies["user"] == null)
        {
            lblpage2.Text = "Login First!";
            //Response.Write("<script>alert('Login First!')</script>");
            Response.Redirect("~/Default.aspx");
        }
        else 
        {
            lblpage2.Text += " "+Request.Cookies["user"]["username"];
        }
    }
}
