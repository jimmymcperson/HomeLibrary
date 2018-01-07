using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Setup : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void darkButton_Click(object sender, EventArgs e)
    {
        // save theme into cookie
        Session["Theme"] = "dark";
        HttpCookie themeCookie = new HttpCookie("theme", "dark");
        themeCookie.Expires = DateTime.Now.AddMonths(1);
        Response.Cookies.Add(themeCookie);
        Response.Redirect(Request.RawUrl);
    }

    protected void lightButton_Click(object sender, EventArgs e)
    {
        // save theme into cookie
        Session["Theme"] = "light";
        HttpCookie themeCookie = new HttpCookie("theme", "light");
        themeCookie.Expires = DateTime.Now.AddMonths(1);
        Response.Cookies.Add(themeCookie);
        Response.Redirect(Request.RawUrl);
    }
}