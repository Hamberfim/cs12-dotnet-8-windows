using Packt.Shared;  // use Person class from the Packt.Shared namespace
#region Console Configuration
ConfigureConsole();  // sets current culture to default set in Program.Helpers.cs

// alternatives
// ConfigureConsole(useComputerCulture  : true);  // use the culture set by the OS
// ConfigureConsole(culture: "fr-FR");  // French (France)
#endregion

#region create an instance of the Person class
// create an instance of the Person class
Person bill = new();
// WriteLine(bill.ToString());
WriteLine(bill);  // implicit call to ToString() --displays console cultural info
#endregion

#region set properties of the 'bill' instance of the Person class
bill.Name = "Bill Smith";
bill.Born = new DateTimeOffset(
    year: 1966,
    month: 4,
    day: 3,
    hour: 7,
    minute: 29,
    second: 0,
    offset: TimeSpan.FromHours(-5));  // eastern US time zone
WriteLine($"{bill.Name} was born on {bill.Born:D}.");  // :D is the long date format

bill.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
WriteLine($"{bill.Name}'s favorite ancient wonder is {bill.FavoriteAncientWonder} which is number {(int)bill.FavoriteAncientWonder} on the ancient wonder list.");
bill.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon
    | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
WriteLine($"{bill.Name}'s bucket list is {bill.BucketList}.");
#endregion


#region create another instance of the Person class setting it's properties using obj init syntax
// use named object init syntax
Person lisa = new()
{
    Name = "Lisa Brown",
    Born = new(
        year: 1972,
        month: 3,
        day: 13,
        hour: 7,
        minute: 3,
        second: 0,
        TimeSpan.Zero)  // optional offset from UTC
};
WriteLine($"{lisa.Name} was born on {lisa.Born}.");
lisa.FavoriteAncientWonder = WondersOfTheAncientWorld.GreatPyramidOfGiza;
WriteLine($"{lisa.Name}'s favorite ancient wonder is {lisa.FavoriteAncientWonder} which is number {(int)lisa.FavoriteAncientWonder} on the ancient wonder list.");
lisa.BucketList = WondersOfTheAncientWorld.ColossusOfRhodes
    | WondersOfTheAncientWorld.GreatPyramidOfGiza;
WriteLine($"{lisa.Name}'s bucket list is {lisa.BucketList}.");
#endregion

#region create Person instances and add them to a Children list
// child of bill
Person steven = new Person();
steven.Name = "Steven";
bill.Children.Add(steven); // bills children list

// child of bill C# 9 and later syntax
bill.Children.Add(new() { Name = "Bethanie" });
bill.Children.Add(new() { Name = "Kathryn" });
WriteLine($"\n{bill.Name} has {bill.Children.Count} children:");
// loop thru children list
for (int childIndex = 0; childIndex < bill.Children.Count; childIndex++)
{
    WriteLine($"{bill.Children[childIndex].Name}");
}

// child of lisa
Person paul = new Person();
paul.Name = "Paul";
lisa.Children.Add(paul);

// child of lisa C# 9 and later syntax
lisa.Children.Add(new() { Name = "Mary Lou" });
WriteLine($"\n{lisa.Name} has {lisa.Children.Count} children:");
// loop thru children list
foreach (var child in lisa.Children)
{
    WriteLine(child.Name);
}
#endregion

#region static member to share one value across all instances
// store the shared value in the static field
BankAccount.InterestRate = 0.012M;

//  sett up BankAccount instances
BankAccount smithAccount = new();
smithAccount.AccountName = "Mr. Bill Smith";
smithAccount.Balance = 2400;
WriteLine($"{smithAccount.AccountName} has earned {(smithAccount.Balance * BankAccount.InterestRate):C} interest.");

BankAccount brownAccount = new();
brownAccount.AccountName = "Mrs. Lisa Brown";
brownAccount.Balance = 98;
WriteLine($"{brownAccount.AccountName} has earned {(brownAccount.Balance * BankAccount.InterestRate):C} interest.");
#endregion

#region Constant fields are accessible via the type
WriteLine($"\n{bill.Name} is a {Person.Species}.");
WriteLine($"{lisa.Name} is a {Person.Species}.");

// readonly fields are accessible via the variable
WriteLine($"\n{bill.Name} was born on {bill.HomePlanet}");
WriteLine($"{lisa.Name} was born on {lisa.HomePlanet}");
#endregion

#region Required - requireing fields to be set during instantiation
Book someBook = new() { Isbn = "978-0-321-87758-1", Title = "Professional C# .Net 8" };  // Isbn & Title are required
WriteLine($"\n{someBook.Title} was written by {someBook.Author = "Unknown"}, has {someBook.PageCount = 325} pages and an ISBN of {someBook.Isbn}");
Book anotherBook = new(isbn: "000-0-000-00000-0", title: "Empty Record") { Author = "Pseudonym", PageCount = 0 };
WriteLine($"{anotherBook.Title} was written by {anotherBook.Author}, has {anotherBook.PageCount} pages and an ISBN of {anotherBook.Isbn}");
#endregion

#region initialize fields using constructors
Person emptyPerson = new();  // calls the default constructor
WriteLine($"{emptyPerson.Name}, born on {emptyPerson.HomePlanet} was created at {emptyPerson.CreationStamp:hh:mm:ss} on a {emptyPerson.CreationStamp:dddd}.");

Person jimmy = new(initialName: "Jimmy", homePlanet: "Mars");
WriteLine($"{jimmy.Name}, born on {jimmy.HomePlanet} was created at {jimmy.CreationStamp:hh:mm:ss} on a {jimmy.CreationStamp:dddd}.");
#endregion
