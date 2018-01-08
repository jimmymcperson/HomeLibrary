using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data;

/// <summary>
/// This class defines a connection ti a database.
/// </summary>
public class ConnectionClass
{
    // PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    public DataTable dt { get; set; }
    public OleDbCommand cmd { get; set; }
    public OleDbCommandBuilder cb { get; set; }
    public OleDbConnection con { get; set; }
    public OleDbDataAdapter da { get; set; }
    public OleDbDataReader rdr { get; set; }

    // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    /// <summary>
    /// This constructor builds the connection string.
    /// </summary>
    public ConnectionClass()
    {
        //con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Jon\\Desktop\\College\\Semester6\\COMP229\\assignment1\\HomeLibrary\\HomeLibrary\\Database1.mdb");
        con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database1.mdb");

    }

    // METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    /// <summary>
    /// This method edits an entry in the database.
    /// </summary>
    public void AddEntry(string isbn, string title, string author, string genre, string pages, bool lended, string friendName, string comments)
    {
        string answer;
        if (lended)
        {
            answer = "Yes";
        }
        else
        {
            answer = "No";
        }
        OleDbCommand cmd = new OleDbCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "insert into Book(ISBN, Title, Author, Genre, Pages, Lended, FriendName, Comments)"
            + " VALUES (@ISBN, @Title, @Author, @Genre, @Pages, @Lended, @FriendName, @Comments)";
        cmd.Parameters.AddWithValue("@ISBN", isbn);
        cmd.Parameters.AddWithValue("@Title", title);
        cmd.Parameters.AddWithValue("@Author", author);
        cmd.Parameters.AddWithValue("@Genre", genre);
        cmd.Parameters.AddWithValue("@Pages", pages);
        cmd.Parameters.AddWithValue("@Lended", answer);
        cmd.Parameters.AddWithValue("@FriendName", friendName);
        cmd.Parameters.AddWithValue("@Comments", comments);
        cmd.Connection = con;

        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            con.Close();
        }
    }
        /// <summary>
        /// This method commits changes to the database.
        /// </summary>
        public void CommitChanges(string statement, DataTable dt)
    {
        da = new OleDbDataAdapter(statement, con);
        cb = new OleDbCommandBuilder(da);
        try
        {
            da.Update(dt);
        }
        catch (Exception)
        {
            throw;
        }
    }

    /// <summary>
    /// This method deletes an entry from the database.
    /// </summary>
    public void DeleteEntry(string item)
    {
        cmd = new OleDbCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = string.Format("Delete From Book where Title = '" + item + "'");
        cmd.Connection = con;

        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            con.Close();
        }
    }

    /// <summary>
    /// This method edits an entry in the database.
    /// </summary>
    public void EditEntry(string isbn, string title, string author, string genre, string pages, string lended, string friendName, string comments)
    {
        OleDbCommand cmd = new OleDbCommand( );
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "update Book set ISBN = @ISBN, Title = @Title, Author = @Author, Genre = @Genre, Pages = @Pages, Lended = @Lended, FriendName = @FriendName, Comments = @Comments where ISBN = " + isbn;
        cmd.Parameters.AddWithValue("@ISBN", isbn);
        cmd.Parameters.AddWithValue("@Title", title);
        cmd.Parameters.AddWithValue("@Author", author);
        cmd.Parameters.AddWithValue("@Genre", genre);
        cmd.Parameters.AddWithValue("@Pages", pages);
        cmd.Parameters.AddWithValue("@Lended", lended);
        cmd.Parameters.AddWithValue("@FriendName", friendName);
        cmd.Parameters.AddWithValue("@Comments", comments);
        cmd.Connection = con;

        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            con.Close();
        }
    }

    /// <summary>
    /// This method queries the database and returns the results in a datatable object.
    /// </summary>
    public DataTable QueryDatabase(string query)
    {
        // build query string
        cmd = new OleDbCommand(query, con);

        // query
        try
        {
            con.Open();
            rdr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(rdr);
            return dt;
        }
        catch (System.Exception)
        {
            throw;
        }
        finally
        {
            con.Close();
        }

    }
}