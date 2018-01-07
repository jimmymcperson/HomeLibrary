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
        con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Jon\\Desktop\\College\\Semester6\\COMP229\\assignment1\\HomeLibrary\\HomeLibrary\\Database1.mdb");
    }

    // METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

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