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

    #region methods with parameters and overloading methods
    public string SayHello() { return $"{Name} says, 'Hello!'"; }
    public string SayHello(string name) { return $"{Name} says, 'Hello, {name}!'"; }  // overloaded method
    public string SayHelloTwo(string name) { return $"{Name} says, 'Hello, {name}!'"; }
    #endregion

    #region optional parameters
    public string OptionalParams(string command = "Run!", double decNumber = 0.0, bool active = true)
    {
        return $"Command: {command}, decNumber: {decNumber:N1}, active: {active}";
    }
    #endregion

    #region Using Tuples for mutiple return values
    public (string, int) GetFruit() { return ("Oranges", 12); }
    // named tuple field elements
    public (string Name, int Count) GetNamedFruit()
    {
        return (Name: "Kiwi", Count: 9);
    }
    #endregion

}