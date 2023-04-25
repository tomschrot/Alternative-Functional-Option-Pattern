
using Option.Models;
using Option.Infrastructure;

WriteLine ("Alternative Functional Option-Pattern\nby Tom Schröter\n");

Person mann      = Person.Create ("Thomas", "Mann");
Person aristotle = Person.Create ("Aristotle");

Book faustus = Book.Create ("Faust", mann);
Book retoric = Book.Create ("Retoric", aristotle);
Book nights  = Book.Create ("1000 And One Nights");

var bookshelf = new[] {faustus, retoric, nights}
    .GroupBy (initialOf)
    .OrderBy (group => group.Key.Or(String.Empty))
    ;

foreach (var group in bookshelf)
{
    WriteLine ($"[ {group.Key} ] -> {group.First()}");
}

static string initialOf (Book book)
=>
    book.Author.Option
    (
        map: author => author.GetInitial(),
        or : String.Empty
    );

WriteLine ($"\r\nOK @ {DateTime.Now}");
