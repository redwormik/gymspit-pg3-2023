int max;
bool success;

do {
	Console.Write("Please enter a positive number: ");
	string input = Console.ReadLine();
	success = int.TryParse(input, out max) && max > 0;

	if (!success) {
		Console.WriteLine("\"{0}\" is not a positive number!", input);
	}
} while (!success);


for (int i = 1; i <= max; i += 1) {
	if (i > 1) {
		Console.Write(", ");
	}

	if (i % 3 == 0 && i % 5 == 0) {
		Console.Write("FIZZ BUZZ");
	} else if (i % 3 == 0) {
		Console.Write("Fizz");
	} else if (i % 5 == 0) {
		Console.Write("Buzz");
	} else {
		Console.Write(i);
	}
}

Console.WriteLine();