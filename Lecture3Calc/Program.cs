char operation;

do {
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
	operation = Console.ReadKey().KeyChar;
	Console.WriteLine();

	switch (operation) {
		case '+':
		case 's':
		case 'S':
			operation = '+';
			break;
		case '-':
		case 'o':
		case 'O':
			operation = '-';
			break;
		case '*':
		case 'n':
		case 'N':
			operation = '*';
			break;
		case '/':
		case 'd':
		case 'D':
			operation = '/';
			break;
		case '%':
		case 'z':
		case 'Z':
			operation = '%';
			break;
		case '^':
		case 'm':
		case 'M':
			operation = '^';
			break;
		case 'q':
		case 'Q':
		case 'x':
		case 'X':
			operation = 'q';
			break;
		default:
			Console.WriteLine("Neplatná operace!");
			break;
	}

	if (operation == '+' || operation == '-' || operation == '*' || operation == '/' || operation == '%' || operation == '^') {
		double operand1, operand2, result;
		bool success;

		do {
			Console.Write("Zadejte číslo: ");
			string input = Console.ReadLine();
			success = double.TryParse(input, out operand1);
			if (!success) {
				Console.WriteLine("\"{0}\" není číslo!", input);
			}
		} while (!success);

		bool nonZero = operation == '/' || operation == '%' || (operation == '^' && operand1 == 0.0);
		string label = nonZero ? "nenulové číslo" : "číslo";

		do {
			Console.Write("Zadejte {0}: ", label);
			string input = Console.ReadLine();
			success = double.TryParse(input, out operand2) && !(nonZero && operand2 == 0.0);
			if (!success) {
				Console.WriteLine("\"{0}\" není {1}!", input, label);
			}
		} while (!success);


		switch (operation) {
			case '+':
				result = operand1 + operand2;
				break;
			case '-':
				result = operand1 - operand2;
				break;
			case '*':
				result = operand1 * operand2;
				break;
			case '/':
				result = operand1 / operand2;
				break;
			case '%':
				result = operand1 % operand2;
				break;
			case '^':
				result = Math.Pow(operand1, operand2);
				break;
			default:
				// should not happen
				result = double.NaN;
				break;
		}

		Console.WriteLine("{1} {0} {2} = {3}", operation, operand1, operand2, result);
		Console.WriteLine();
	}
} while (operation != 'q');
