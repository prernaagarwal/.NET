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
        if (!IsPostBack)
        {
     
        }
    }

    private void createCookie()
    {
        HttpCookie cookie1 = new HttpCookie("user");
        cookie1.Values["username"] = txtusername.Text;
        cookie1.Values["password"] = txtpassword.Text;
        cookie1.Expires = System.DateTime.Now.AddSeconds(30);
        Response.Cookies.Add(cookie1);
    }

    protected void btn1_Click(object sender, EventArgs e)
    {
        createCookie();
        Response.Write("Cookie Set");
        Response.Redirect("~/Default2.aspx");
    }
}