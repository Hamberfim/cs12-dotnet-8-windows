namespace Packt.Shared;

// implicit inheritance from System.Object
public class Person 
{
    #region Fields: data or state for this person
    public string? Name;  // nullable
    public DateTimeOffset Born;
    #endregion
}