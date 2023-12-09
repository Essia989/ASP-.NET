// See https://aka.ms/new-console-template for more information
#pragma warning restore CS8602 // Dereference of a possibly null reference.
using System.Linq;

Console.WriteLine("LINQ Eruption Assignment!");


List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!



System.Console.WriteLine("======================CHILE==========================");

IEnumerable<Eruption> InChile = eruptions.Where(c => c.Location == "Chile");
PrintEach(InChile, "Chile");

System.Console.WriteLine("========================Hawaiian========================");

Eruption? HawaiianIn = eruptions.FirstOrDefault(d => d.Location == "Hawaiian Is");   // single  

if (HawaiianIn != null)
{
    System.Console.WriteLine(HawaiianIn);
}
else
{
    System.Console.WriteLine("No Hawaiian is Eruption found");
}

System.Console.WriteLine("================================After 1900================================");

Eruption? After1900 = eruptions.FirstOrDefault(d => d.Year > 1900 && d.Location =="New Zealand");
System.Console.WriteLine(After1900);

System.Console.WriteLine("================================ Over 2000m ================================");

IEnumerable<Eruption> Over2000m = eruptions.Where(s => s.ElevationInMeters > 2000);
PrintEach(Over2000m);

System.Console.WriteLine("================================ Starts with 'L' ================================");

/*IEnumerable<Eruption> StartsL = eruptions.Where(x => x.Volcano.Any(y => y.StartsWith("L")));
PrintEach(Over2000m);*/

System.Console.WriteLine("================================ Max Eruption ================================");

int MaxElevation = eruptions.Max(a => a.ElevationInMeters);
System.Console.WriteLine(MaxElevation.ToString ());

System.Console.WriteLine("================================ Name of Max Eruption ================================");

Eruption? Name_MaxElevation = eruptions.FirstOrDefault(a => a.ElevationInMeters == MaxElevation);
#pragma warning disable CS8602 // Dereference of a possibly null reference.
System.Console.WriteLine(Name_MaxElevation.Volcano.ToString ());

System.Console.WriteLine("================================ Volcano names Sorted Alphabetically ================================");

IEnumerable<Eruption> AllVolcanos = eruptions.OrderBy(s => s.Volcano);

foreach (var item in AllVolcanos)
    {
        Console.WriteLine(item.Volcano.ToString());
    }

System.Console.WriteLine("================================ Volcano before 1000CE names Sorted Alphabetically ================================");

IEnumerable<Eruption> AllVolcanos1000CE = eruptions.Where(s => s.Year < 1000).OrderBy(p => p.Volcano).ToList();

foreach (var item in AllVolcanos1000CE)
    {
        Console.WriteLine(item.Volcano.ToString());
    }


// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}