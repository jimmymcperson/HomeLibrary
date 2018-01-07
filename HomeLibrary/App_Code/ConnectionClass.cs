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
    /// This constructor builds the connection string and dataadapter.
    /// </summary>
    public ConnectionClass()
    {
        con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=database1.mdb");
    }

}