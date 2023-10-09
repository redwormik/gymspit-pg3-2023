Console.Write("Please enter a number: ");

if (!int.TryParse(Console.ReadLine(), out int level)) {
	Console.WriteLine("That is not a number!");
	Environment.Exit(1);
}

Console.Write("Please enter a species: ");
string species = Console.ReadLine();

Console.Write("Please enter a class: ");
string className = Console.ReadLine();

Console.Write("Please enter an action: ");
string action = Console.ReadLine();

Console.Write("Please enter a weapon: ");
string weapon = Console.ReadLine();

Console.Write("Please enter an adjective: ");
string adjective = Console.ReadLine();

Console.Write("Please enter a noun: ");
string noun = Console.ReadLine();

Console.WriteLine(
	"A level {0} {1} {2} {3}s their {4} at the {5} {6}.",
	level,
	species,
	className,
	action,
	weapon,
	adjective,
	noun
);