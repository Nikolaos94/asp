using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SQLQuery
/// </summary>
public class SQLQuery
{
    public const string NewsInsert = "Insert into news(Title, Author, Content, CreateDate, Image)VALUES(@Title, @Author, @Content, @CreateDate, @Image)";
    public const string InsertActivationCode = "Insert Into UserActivation Values(@UserId, @ActivationCode)";
}