// https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/
// https://docs.microsoft.com/en-us/dotnet/api/system.exception

static bool Input(ref int a, ref int b)
{
	string input = "";

	try {
		Console.Write("Enter a: ");
		a = int.Parse(input = Console.ReadLine());
		Console.Write("Enter b: ");
		b = int.Parse(input = Console.ReadLine());

		// pokud se program dostane sem, tak se čtení podařilo
		return true;
	} catch (FormatException) {
		Console.WriteLine("Invalid input: {0}", input);
		return false;
	}
}

static void InputLoop(out int a, out int b)
{
	bool success;

	a = b = 0;
	do {
		success = Input(ref a, ref b);
	} while (!success);
}

static int Div(int a, int b)
{
	if (b == 1) {
		throw new ArgumentException("Why do you divide by one?");
	}

	return a / b;
}

static void Compute(int a, int b)
{
	try {
		int result = Div(a, b);
		Console.WriteLine("{0} / {1} = {2}", a, b, result);
	} catch (DivideByZeroException e) {
		Console.WriteLine("Cannot divide by zero!");
		Console.WriteLine(e.StackTrace);
	} catch (Exception) {
		Console.WriteLine("Another exception happened!");
		throw;
	} finally {
		Console.WriteLine("Finally, it's over!");
	}
}

static int D6(int last, Random rnd)
{
	int result = rnd.Next(1, 7);
	Console.WriteLine("D6: {0}", result);
	if (result == last) {
		throw new CustomException("Go to jail!");
	}
	return result;
}

static int CastDice(int num, Random rnd)
{
	int sum = 0;
	int last = 0;

	try {
		for (int i = 0; i < num; i += 1) {
			last = D6(last, rnd);
			sum += last;

			if (sum > 21) {
				Console.WriteLine("Bust!");
				return -1;
			}
		}
	} finally {
		Console.WriteLine("Good luck next time!");
	}

	return sum;
}

static void Game(int a, Random rnd)
{
	try {
		int result = CastDice(a, rnd);
		Console.WriteLine("Your result: {0}", result);
	} catch (CustomException e) {
		Console.WriteLine(e.Message);
	}
}


InputLoop(out int a, out int b);

try {
	Compute(a, b);
} catch (ArgumentException e) {
	Console.WriteLine(e.Message);
}

Game(a, new Random());