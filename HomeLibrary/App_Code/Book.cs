using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// This class defines a book.
/// </summary>
public class Book
{
    //PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    
    public string Name { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public string Genre { get; set; }
    public int Pages { get; set; }
    public bool Lended { get; set; }
    public string FriendName { get; set; }
    public string Comments { get; set; }


    //CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    /// <summary>
    /// This constructor initializes all variables.
    /// </summary>
    public Book(string name, string author, string isbn, string genre, int pages, bool lended, string friendName, string comments)
    {
        Name = name;
        Author = author;
        ISBN = isbn;
        Genre = genre;
        Pages = pages;
        Lended = lended;
        FriendName = friendName;
        Comments = comments;
    }
}