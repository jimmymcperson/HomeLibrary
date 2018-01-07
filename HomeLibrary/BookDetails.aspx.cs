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
            BookDetailsView.DataSource = dt;
            BookDetailsView.DataBind();
        }
    }

    protected void DeleteBookButton_Click(object sender, EventArgs e)
    { 
        string bookTitle = Session["SelectedBook"].ToString();
        con.DeleteEntry(bookTitle);
        Server.Transfer("books.aspx");
    }

    protected void BookDetailsView_ModeChanging(object sender, DetailsViewModeEventArgs e)
    {
        BookDetailsView.ChangeMode(e.NewMode);
    }

    protected void BookDetailsView_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
    {
        //con.EditEntry();
        con.CommitChanges("select * from Book", (DataTable)BookDetailsView.DataSource);
    }

    protected void BookDetailsView_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
    {
        con.CommitChanges("select * from Book", (DataTable)BookDetailsView.DataSource);
    }
}