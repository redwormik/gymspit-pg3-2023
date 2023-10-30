// https://docs.microsoft.com/en-us/dotnet/csharp/methods#method-signatures
// Deklarace funkce:
// - viditelnost (zatím neřešíme)
// - static (voláme ji samostatně, ne na objektu)
// - návratový typ nebo void
// - název (konvence je PascalCase)
// - parametry (typ + název)
// - tělo funkce
static void SayHello()
{
	Console.WriteLine("What's your name?");
	SayHelloTo(Console.ReadLine());
}

static void SayHelloTo(string name)
{
	Console.WriteLine("Hello, {0}!", name);
}

// https://docs.microsoft.com/en-us/dotnet/csharp/methods#optional-parameters-and-arguments
static void SayHelloWithDefault(string name = "Everyone")
{
	SayHelloTo(name);
}

static int ReadInt()
{
	int result;
	bool success;

	do {
		Console.Write("Please input a number: ");
		string input = Console.ReadLine();
		success = int.TryParse(input, out result);

		if (!success) {
			Console.WriteLine("\"{0}\" is not a number!", input);
		}
	} while (!success);

	// Návratová hodnota funkce
	// https://docs.microsoft.com/en-us/dotnet/csharp/methods#return-values
	return result;
}

static int Add(int operand1, int operand2)
{
	return operand1 + operand2;
}

// Out a ref parametry:
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/out
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref
static void Increment(ref int value, out bool even)
{
	// Console.WriteLine(even); // nejde - even není nastavená
	value += 1;
	even = value % 2 == 0;
	// Console.WriteLine(even); // tady by to šlo
}

// Volání funkce
// https://docs.microsoft.com/en-us/dotnet/csharp/methods#method-invocation
SayHello();
SayHelloTo("World");
SayHelloWithDefault("Galaxy");
SayHelloWithDefault();


// Proměnné a parametry ve funkci jsou normálně oddělené od zbytku programu
// Změna hodnoty parametru ve funkci se mimo funkci neprojeví,
// pokud nepoužiju out/ref (a je to hodnotový typ)
// https://docs.microsoft.com/en-us/dotnet/csharp/methods#passing-parameters

int result = ReadInt();
int result2 = ReadInt();
Console.WriteLine(result);
Console.WriteLine(result2);

Console.WriteLine("{0} + {1} = {2}", 13, 25, Add(13, 25));
Console.WriteLine("{0} + {1} = {2}", result, result2, Add(result, result2));

// Pozor, každé volání pustí funkci znovu!
Console.WriteLine("{0} + {1} = {2}", ReadInt(), ReadInt(), Add(ReadInt(), ReadInt()));

int answer = 40;
bool isEven;
Console.WriteLine(answer);
// Console.WriteLine(isEven); // nejde - isEven není nastavená
Increment(ref answer, out isEven);
Console.WriteLine(answer);
Console.WriteLine(isEven);
Increment(ref answer, out isEven);
Console.WriteLine(answer);
Console.WriteLine(isEven);

// Increment(ref 42); // nejde - ref argumenty můžou být jen proměnné
