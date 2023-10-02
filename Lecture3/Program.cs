// a += b je to samé jako a = a + b
// (podobně a -= b, a *= b, a /= b, ...)

int x = 0;
Console.WriteLine("i == {0}", x);
x += 5;
Console.WriteLine("i += {0}", 5);
Console.WriteLine("i == {0}", x);
x *= 6;
Console.WriteLine("i *= {0}", 6);
Console.WriteLine("i == {0}", x);
x -= 7;
Console.WriteLine("i -= {0}", 7);
Console.WriteLine("i == {0}", x);
x /= 8;
Console.WriteLine("i /= {0}", 8);
Console.WriteLine("i == {0}", x);
Console.WriteLine();

Console.WriteLine("i == {0}", x);
Console.WriteLine("(i = {1}) == {0}", x = 1, 1);
Console.WriteLine("i == {0}", x);
Console.WriteLine("(i += {1}) == {0}", x += 2, 2);
Console.WriteLine("i == {0}", x);
Console.WriteLine("(i *= {1}) == {0}", x *= 3, 3);
Console.WriteLine("i == {0}", x);
Console.WriteLine("(i -= {1}) == {0}", x -= 4, 4);
Console.WriteLine("i == {0}", x);
Console.WriteLine("(i /= {1}) == {0}", x /= 5, 5);
Console.WriteLine("i == {0}", x);
Console.WriteLine();

// a += 1 se dá zkrátit na ++a
// a -= 1 se dá zkrátit na --a

// Rozdíl mezi i++ a ++i je v hodnotě celého výrazu:
// - hodnota i++ je stejná jako i před inkrementací
// - hodnota ++i je stejná jako i po inkrementaci
int a = 2, b = 4;
Console.WriteLine("a == {0}, b == {1}", a, b);
Console.WriteLine("a++ == {0}, ++b == {1}", a++, ++b);
Console.WriteLine("a == {0}, b == {1}", a, b);
Console.WriteLine();

// Podobně i-- a --i
int c = 6, d = 8;
Console.WriteLine("c == {0}, d == {1}", c, d);
Console.WriteLine("c-- == {0}, --d == {1}", c--, --d);
Console.WriteLine("c == {0}, d == {1}", c, d);
Console.WriteLine();


string input;
do {
	Console.WriteLine("Enter a text line: ");
	input = Console.ReadLine();
} while (input.Length < 3);

Console.WriteLine("You entered: {0}", input);
Console.WriteLine();


// proměnná typu char pro jeden znak
char literalChar = '@'; // literály se zapisují do apostrofů (')
char firstChar = input[0]; // můžu číst jeden znak z řetězce, číslují se od nuly
char thirdChar = input[2];
// char lastChar = input[input.Length - 1];
char lastChar = input[^1];

Console.WriteLine("'{0}' '{1}' '{2}' '{3}'", literalChar, firstChar, thirdChar, lastChar);

char inputKey;
do {
	Console.Write("Press any key: ");
	// ReadKey vrací typ ConsoleKeyInfo,to má vlastnost KeyChar
	// https://docs.microsoft.com/en-us/dotnet/api/system.consolekeyinfo.keychar?view=net-5.0
	inputKey = Console.ReadKey().KeyChar;
	Console.WriteLine();

	// klávesy, co nemají svůj znak, vrací "nulový" znak
	if (inputKey == '\u0000') { // '\u0000' je znak s Unicode číslem 0
		Console.WriteLine("You pressed a special key!");
	} else {
		Console.WriteLine("You pressed: '{0}'", inputKey);
	}

	// dá se použít i ConsoleKeyInfo.Key
	// https://docs.microsoft.com/en-us/dotnet/api/system.consolekeyinfo.key?view=net-5.0
} while (inputKey != 'x' && inputKey != 'X');


// break přeruší cyklus
int result = 0;         // musím proměnné inicializovat
bool success = false;   // protože kvůli break nemusí dostat hodnotu v cyklu

do {
	Console.Write("Please input a number: ");
	string numberInput = Console.ReadLine();
	if (numberInput.ToLower() == "exit") {
		break;
	}

	success = int.TryParse(numberInput, out result);
	if (!success) {
		Console.WriteLine("\"{0}\" is not a number!", numberInput);
	}
} while (!success);
// break skočí sem

Console.WriteLine("success = {0}, result = {1}", success, result);


// continue přeruší iteraci cyklu
int sum = 0;
for (int i = 1; i <= 20; i += 1) {
	if (i % 3 == 0) {
		Console.WriteLine("{0} is divisible by 3, skipping!", i);
		continue;
	}

	sum += i;

	// continue skočí sem
}
Console.WriteLine("sum = {0}", sum);


// switch vybere první hodnotu, co odpovídá
// podobně jako řada if-else
Console.Write("Choose a color (R/G/B): ");
char color = Console.ReadKey().KeyChar;
Console.WriteLine();

switch (color) {
	case 'R':
		Console.WriteLine("Red");
		break; // každá větev musí končit breakem
	case 'r':
		Console.WriteLine("Red");
		break;

	case 'G': // můžu mít prázdnou větev - propadne do první neprázdné
	case 'g': // chová se podobně jako || v if-u
		Console.WriteLine("Green");
		break;

	case 'B':
	case 'b':
		Console.WriteLine("Blue");
		break;

	default: // odpovídá vždy, jako else
		Console.WriteLine("Unknown color!");
		break; // i default musí končit breakem
}