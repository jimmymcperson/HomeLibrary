using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Addbook : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// This handler reveals friend name input when "lended" checkbox is checked.
    /// </summary>
    protected void lendedCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        friendNameLabel.Visible = lendedCheckBox.Checked;
        friendNameTextBox.Visible = lendedCheckBox.Checked;
        friendNameTextBox.Enabled = lendedCheckBox.Checked;
        friendNameRequiredFieldValidator.Enabled = lendedCheckBox.Checked;
    }

    /// <summary>
    /// This handler causes server-side validation and adds to a list of books based on web form input.
    /// </summary>
    protected void saveButton_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            if (Application["Books"] == null)
            {
                Application["Books"] = new List<Book>();
            }
            // casting to ensure program that Application["Books"] is List<Book>
            List<Book> listOfBooks = (List<Book>)Application["Books"];
            // create new book based on entries
            Book book = new Book(nameTextBox.Text, authorTextBox.Text, isbnTextBox.Text, genreDropDownList.SelectedItem.Text, Int32.Parse(pagesTextBox.Text), lendedCheckBox.Checked, friendNameTextBox.Text, commentsTextBox.Text);
            // add new book to the list
            listOfBooks.Add(book);
        }
    }
}