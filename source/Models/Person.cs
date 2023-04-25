
using static Option.Infrastructure.Extensions;

namespace Option.Models;

public sealed class Person
{
    //-------------------------------------------------------------------------
    public static Person Create (string firstname = null, string lastname = null)
    =>
        new (firstname, lastname);
    //-------------------------------------------------------------------------

    public string Firstname	{get; init;}
    public string Lastname	{get; init;}
    //-------------------------------------------------------------------------

    public Person(string firstname, string lastname)
    =>
        (Firstname, Lastname) = (firstname, lastname);
    //-------------------------------------------------------------------------

    override
    public string ToString ()
    =>
        $"{Firstname.Or("Unknown")} {Lastname.Or(String.Empty)}";
    //-------------------------------------------------------------------------

    public string GetInitial ()
    {
        return
            Lastname.Option
            (
                map: initial,
                or : initial (Firstname)
            );
        //-------------------------------------------------

        static string initial (string name)
        =>
            name.Length == 0
            ? String.Empty
            : name.Trim().Substring(0, 1).ToUpper();
        //-------------------------------------------------
    }
    //-------------------------------------------------------------------------
}
