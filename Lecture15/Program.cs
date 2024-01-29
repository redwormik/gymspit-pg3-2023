using Lecture15;

// https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/classes
// https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/
// https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/objects

Animal rex = new Animal("dog", "Rex");
Console.WriteLine("My {0} is named {1}", rex.Species, rex.Name);

Animal garfield = new Animal("cat", "Garfield", "Garf");
Console.WriteLine("My {0} is named {1}, I call him {2}", garfield.Species, garfield.Name, garfield.Nickname);

garfield.Nickname = "Lasagne Eater";
Console.WriteLine("Now I call him {0}", garfield.Nickname);

Console.WriteLine(rex.Speak());
Console.WriteLine(garfield.Speak());
Console.WriteLine((new Animal("fox", "fox")).Speak());

bool responds;

responds = garfield.Call("Garfield");
Console.WriteLine(responds ? "Pet responds" : "Pet does not respond");

responds = garfield.Call("Lasagne Eater");
Console.WriteLine(responds ? "Pet responds" : "Pet does not respond");

responds = garfield.Call("Rex");
Console.WriteLine(responds ? "Pet responds" : "Pet does not respond");


Console.WriteLine("Skoda:");
Car skoda = new Car(new Engine(90, 10.0 / 100), new GasTank(25));
skoda.Tank(15);
skoda.Go(25);

try {
	skoda.Tank(15);
} catch (ArgumentException) {
	Console.WriteLine("Tank overflow!");
}

skoda.Go(100);
try {
	skoda.Go(175);
} catch (ArgumentException) {
	Console.WriteLine("Tank underflow!");
}

Console.WriteLine("Felicie:");
Car felicie = new Car(new Engine(130, 7.0 / 100), new GasTank(40));
felicie.Tank(20);
felicie.Go(200);
felicie.Tank(20);
felicie.Go(300);

try {
	felicie.Go(300);
} catch (ArgumentException) {
	Console.WriteLine("Tank underflow!");
}