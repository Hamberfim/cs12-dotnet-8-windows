namespace Packt.Shared;

// implicit inheritance from System.Object
public class Person 
{
    #region Fields: data or state for person
    public string? Name;  // nullable
    public DateTimeOffset Born;

    public WondersOfTheAncientWorld FavoriteAncientWonder;
    public WondersOfTheAncientWorld BucketList;
    #endregion
}