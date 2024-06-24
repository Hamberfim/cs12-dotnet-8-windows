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

    public readonly DateTime CreationStamp;
    #endregion

    #region Constructors - called when using new to instantiate a type
    public Person()
    {
        // constructors can set default value
        Name = "Unknown";
        CreationStamp = DateTime.Now;
    }

    public Person(string initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        CreationStamp = DateTime.Now;
    }
    #endregion

    #region Working with methods and tuples : Actions the 'type' can perform
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {Born:dddd}.");
        //WriteLine($"{Name} was born on a {Born.DayOfWeek}.");
    }

    public string GetOrigin()
    {
        return $"{Name} was born on {HomePlanet}.";
    }
    #endregion

    #region methods with parameters
    public string SayHello() { return $"{Name} says, 'Hello!'"; }
    public string SayHelloTwo(string name) { return $"{Name} says, 'Hello, {name}!'"; }
    #endregion

}