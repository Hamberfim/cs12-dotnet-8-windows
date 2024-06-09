namespace Packt.Shared;

// implicit inheritance from System.Object
public class Person 
{
    #region Fields: data or state for person class
    public string? Name;  // nullable
    public DateTimeOffset Born;

    public WondersOfTheAncientWorld FavoriteAncientWonder;
    public WondersOfTheAncientWorld BucketList;

    // store multiple Persons instances
    public List<Person> Children = new();

    // constants
    public const string Species = "Homo Sapiens";

    // read only
    public readonly string HomePlanet = "Earth";
    #endregion
}