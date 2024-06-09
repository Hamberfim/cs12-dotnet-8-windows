namespace Packt.Shared;

public class Book
{
    // needs .Net7+ and C#11+
    public required string? Isbn;
    public required string? Title;

    // works with all versions
    public string? Author;
    public int? PageCount;
}

