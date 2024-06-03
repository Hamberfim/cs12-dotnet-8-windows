using Packt.Shared;  // use Person class from the Packt.Shared namespace

ConfigureConsole();  // sets current culture to default set in Program.Helpers.cs

// alternatives
// ConfigureConsole(useComputerCulture  : true);  // use the culture set by the OS
// ConfigureConsole(culture: "fr-FR");  // French (France)

// creatre an instance of the Person class
Person bill = new();
// WriteLine(bill.ToString());
WriteLine(bill);  // implicit call to ToString()
