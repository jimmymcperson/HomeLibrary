using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class BookDetails : BasePage
{
    ConnectionClass con;
    DataTable dt;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["SelectedBook"] != null)
        {
            string bookTitle = Session["SelectedBook"].ToString();
            con = new ConnectionClass();
            dt = con.QueryDatabase("Select * from Book where Title = '" + bookTitle + "'");
            BookDetailsGridView.DataSource = dt;
            BookDetailsGridView.DataBind();
        }
    }

    protected void DeleteBookButton_Click(object sender, EventArgs e)
    { 
        string bookTitle = Session["SelectedBook"].ToString();
        con.DeleteEntry(bookTitle);
        Server.Transfer("books.aspx");
    }
}