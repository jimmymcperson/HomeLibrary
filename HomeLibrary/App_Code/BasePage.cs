using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BasePage
/// </summary>
public class BasePage : System.Web.UI.Page
{
    public BasePage()
    {
    }

    protected void Page_PreInit(object sender, EventArgs e)
    {
        // get cookie to get theme settings
        HttpCookie themeCookie = Request.Cookies["theme"];
        if (themeCookie != null)
        {
            Page.Theme = themeCookie.Value;

        }
    }
}