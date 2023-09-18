Console.WriteLine("Zadej číslo:");
// double x = double.Parse(Console.ReadLine());
double x;
if (!double.TryParse(Console.ReadLine(), out x)) {
	Console.WriteLine("To není číslo!");
	return;
}

Console.WriteLine("Zadej další číslo:");
double y;
if (!double.TryParse(Console.ReadLine(), out y)) {
	Console.WriteLine("To není číslo!");
	return;
}

Console.WriteLine();

Console.WriteLine("Součet:          {0} + {1} = {2}", x, y, x + y);
Console.WriteLine("Rozdíl A:        {0} - {1} = {2}", x, y, x - y);
Console.WriteLine("Rozdíl B:        {1} - {0} = {2}", x, y, y - x);
Console.WriteLine("Součin:          {0} * {1} = {2}", x, y, x * y);

if (y != 0) {
	Console.WriteLine("Podíl A:         {0} / {1} = {2}", x, y, x / y);
} else {
	Console.WriteLine("Nulou nelze dělit!");
}

if (x != 0) {
	Console.WriteLine("Podíl B:         {1} / {0} = {2}", x, y, y / x);
} else {
	Console.WriteLine("Nulou nelze dělit!");
}

Console.WriteLine("Druhá mocnina A: {0} ^ 2 = {1}",   x, x * x);
Console.WriteLine("Druhá mocnina B: {0} ^ 2 = {1}",   y, y * y);

if (x >= 0) {
	Console.WriteLine("Odmocnina A:     sqrt({0}) = {1}", x, Math.Sqrt(x));
} else {
	Console.WriteLine("V reálných číslech druhá odmocnina záporného čísla neexistuje!");
}

if (y >= 0) {
	Console.WriteLine("Odmocnina B:     sqrt({0}) = {1}", y, Math.Sqrt(y));
} else {
	Console.WriteLine("V reálných číslech druhá odmocnina záporného čísla neexistuje!");
}