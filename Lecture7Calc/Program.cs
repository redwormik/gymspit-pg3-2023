static void PrintMenu()
{
	Console.WriteLine("Vyberte operaci:");
	Console.WriteLine("+/s/S - sčítání");
	Console.WriteLine("-/o/O - odčítání");
	Console.WriteLine("*/n/N - násobení");
	Console.WriteLine("//d/D - dělení");
	Console.WriteLine("%/z/Z - zbytek");
	Console.WriteLine("^/m/M - mocnění");
	Console.WriteLine("q/Q/x/X - konec");
	Console.WriteLine();

	Console.Write("Váš výběr: ");
}


static char ReadOperation()
{
	switch (Console.ReadKey().KeyChar) {
		case '+':
		case 's':
		case 'S':
			return '+';
		case '-':
		case 'o':
		case 'O':
			return '-';
		case '*':
		case 'n':
		case 'N':
			return '*';
		case '/':
		case 'd':
		case 'D':
			return '/';
		case '%':
		case 'z':
		case 'Z':
			return '%';
		case '^':
		case 'm':
		case 'M':
			return '^';
		case 'q':
		case 'Q':
		case 'x':
		case 'X':
			return 'q';
		default:
			return '-';
	}
}


static char ChooseOperation()
{
	char operation;

	do {
		PrintMenu();
		operation = ReadOperation();
		Console.WriteLine();

		if (operation == '-') {
			Console.WriteLine("Neplatná operace!");
		}
	} while (operation == '-');

	return operation;
}


static double ReadDouble(bool nonZero = false)
{
	string label = nonZero ? "nenulové číslo" : "číslo";
	double result;
	bool success;

	do {
		Console.Write("Zadejte {0}: ", label);
		string input = Console.ReadLine();
		success = double.TryParse(input, out result) && !(nonZero && result == 0.0);
		if (!success) {
			Console.WriteLine("\"{0}\" není {1}!", input, label);
		}
	} while (!success);

	return result;
}


static bool NeedsNonZero(char operation, double operand1)
{
	return operation == '/' || operation == '%' || (operation == '^' && operand1 == 0.0);
}


static double Compute(char operation, double operand1, double operand2)
{
	switch (operation) {
		case '+':
			return operand1 + operand2;
		case '-':
			return operand1 - operand2;
		case '*':
			return operand1 * operand2;
		case '/':
			return operand1 / operand2;
		case '%':
			return operand1 % operand2;
		case '^':
			return Math.Pow(operand1, operand2);
		default:
			// should not happen
			return double.NaN;
	}
}


static void WriteResult(char operation, double operand1, double operand2, double result)
{
	Console.WriteLine("{1} {0} {2} = {3}", operation, operand1, operand2, result);
	Console.WriteLine();
}


char operation;
do {
	operation = ChooseOperation();
	if (operation != 'q') {
		double operand1 = ReadDouble();
		double operand2 = ReadDouble(NeedsNonZero(operation, operand1));
		double result = Compute(operation, operand1, operand2);
		WriteResult(operation, operand1, operand2, result);
	}
} while (operation != 'q');
