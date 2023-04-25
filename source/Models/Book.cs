
using static Option.Infrastructure.Extensions;

namespace Option.Models;

public sealed class Book
{
    //-------------------------------------------------------------------------

    public static Book Create (string title, Person author = null)
    =>
        new ()
        {
            Title  = title,
            Author = author
        };
    //-------------------------------------------------------------------------

    public   string Title	{get; init;}
    public   Person Author	{get; init;}
    //-------------------------------------------------------------------------

    override
    public string ToString ()
    =>
        // There are 2 versions of Option():
        // 1. 2nd parameter is a default return value if mapping fails
        $"{Title} by {Author.Option(a => a.ToString() ,"unknown")}";
        // 2. single parameter for map function return null if fails
        // and requires explicit call of ValueOr()
        // $"{Title} by {Author.Option(a => a.ToString()).Or("unknown")}";
    //-------------------------------------------------------------------------
}
