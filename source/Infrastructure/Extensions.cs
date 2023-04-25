
namespace Option.Infrastructure;

public static class Extensions
{
    //-------------------------------------------------------------------------

    public static R Option <T, R> (this T value, Func<T,R> map)
    where T: class
    where R: class
    =>
        value is not null
        ? map(value)
        : null;
    //-------------------------------------------------------------------------

    public static R Option <T, R>
    (
        this T    value,
        Func<T,R> map,
        R         or
    )
    where T: class
    where R: class
    =>
        value is not null
        ? (map(value) ?? or)
        : or;
    //-------------------------------------------------------------------------
    public static T Or <T> (this T obj, T value)
    =>
        obj ?? value;
    //-------------------------------------------------------------------------
}
