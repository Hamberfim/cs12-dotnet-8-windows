using Packt.Shared;  // use Person class from the Packt.Shared namespace

ConfigureConsole();  // sets current culture to default set in Program.Helpers.cs

// alternatives
// ConfigureConsole(useComputerCulture  : true);  // use the culture set by the OS
// ConfigureConsole(culture: "fr-FR");  // French (France)

// creatre an instance of the Person class
Person bill = new();
// WriteLine(bill.ToString());
WriteLine(bill);  // implicit call to ToString()

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