using System.Diagnostics.CodeAnalysis; // to use [SetsRequiredMembers]
namespace Packt.Shared;

public class Book
{
    // needs .Net7+ and C#11+
    public required string? Isbn;
    public required string? Title;

    // works with all versions
    public string? Author;
    public int? PageCount;

    // constructor for use with obj initializer syntax
    public Book() { }

    // constructor with decorator and params to set required fields
    [SetsRequiredMembers]
    public Book(string? isbn, string? title) {
        Isbn = isbn;
        Title = title;
    }
}

