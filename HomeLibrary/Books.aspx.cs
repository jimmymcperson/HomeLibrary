using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Books : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Application["Books"] != null)
        {
            // casting to ensure program that Application["Books"] is List<Book>
            List<Book> listOfBooks = (List<Book>)Application["Books"];
            foreach (Book book in listOfBooks)
            {
                Response.Write(book.Name);
                Response.Write(book.Author);
                Response.Write(book.ISBN);
            }
        }
    }

    /// <summary>
    /// This handler lets you see a detailed view of the book.
    /// </summary>
    protected void bookLink_Click(object sender, EventArgs e)
    {
        Session["SelectedBook"] = (sender as LinkButton).Text;
        Server.Transfer("BookDetails.aspx", true);
    }

    /// <summary>
    /// This handler removes all books from the list
    /// </summary>
    protected void removeAllButton_Click(object sender, EventArgs e)
    {
        Application.RemoveAll();
    }
}