using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Addbook : BasePage
{
    ConnectionClass con;

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
            con = new ConnectionClass();
            con.AddEntry(isbnTextBox.Text, nameTextBox.Text, authorTextBox.Text, genreDropDownList.SelectedItem.Text, pagesTextBox.Text, lendedCheckBox.Checked, friendNameTextBox.Text, commentsTextBox.Text);
        }
    }
}