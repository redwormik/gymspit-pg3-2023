using Lecture20;

MyStack<int> hanoiTower = new MyStack<int>();

Console.WriteLine("Empty: {0}", hanoiTower.Empty);
// Console.WriteLine("Peek: {0}", hanoiTower.Peek);
Console.WriteLine("Contains(2): {0}", hanoiTower.Contains(2));
Console.WriteLine("Contains(7): {0}", hanoiTower.Contains(7));

hanoiTower.Push(1);
Console.WriteLine("Peek after Push(1): {0}", hanoiTower.Peek);

hanoiTower.Push(2);
Console.WriteLine("Peek after Push(2): {0}", hanoiTower.Peek);

Console.WriteLine("Empty: {0}", hanoiTower.Empty);
Console.WriteLine("Peek: {0}", hanoiTower.Peek);
Console.WriteLine("Contains(2): {0}", hanoiTower.Contains(2));
Console.WriteLine("Contains(7): {0}", hanoiTower.Contains(7));

hanoiTower.Clear();
Console.WriteLine("Empty after Clear(): {0}", hanoiTower.Empty);
// Console.WriteLine("Peek after Clear(): {0}", hanoiTower.Peek);
Console.WriteLine("Contains(2): {0}", hanoiTower.Contains(2));
Console.WriteLine("Contains(7): {0}", hanoiTower.Contains(7));

hanoiTower.Push(5);
Console.WriteLine("Peek after Push(5): {0}", hanoiTower.Peek);

hanoiTower.Push(4);
Console.WriteLine("Peek after Push(4): {0}", hanoiTower.Peek);

hanoiTower.Push(3);
Console.WriteLine("Peek after Push(3): {0}", hanoiTower.Peek);

hanoiTower.Push(2);
Console.WriteLine("Peek after Push(2): {0}", hanoiTower.Peek);

hanoiTower.Push(1);
Console.WriteLine("Peek after Push(1): {0}", hanoiTower.Peek);

Console.WriteLine("Empty: {0}", hanoiTower.Empty);
Console.WriteLine("Peek: {0}", hanoiTower.Peek);
Console.WriteLine("Contains(2): {0}", hanoiTower.Contains(2));
Console.WriteLine("Contains(7): {0}", hanoiTower.Contains(7));

foreach (int item in hanoiTower) {
	Console.WriteLine("foreach: {0}", item);
}

Console.WriteLine("Pop: {0}", hanoiTower.Pop());
Console.WriteLine("Peek after Pop(): {0}", hanoiTower.Peek);

Console.WriteLine("Pop: {0}", hanoiTower.Pop());
Console.WriteLine("Peek after Pop(): {0}", hanoiTower.Peek);

Console.WriteLine("Pop: {0}", hanoiTower.Pop());
Console.WriteLine("Peek after Pop(): {0}", hanoiTower.Peek);

hanoiTower.Push(1);
Console.WriteLine("Peek after Push(1): {0}", hanoiTower.Peek);

Console.WriteLine("Empty: {0}", hanoiTower.Empty);
Console.WriteLine("Peek: {0}", hanoiTower.Peek);
Console.WriteLine("Contains(2): {0}", hanoiTower.Contains(2));
Console.WriteLine("Contains(7): {0}", hanoiTower.Contains(7));

while (!hanoiTower.Empty) {
	Console.WriteLine("Pop: {0}", hanoiTower.Pop());
	if (!hanoiTower.Empty) {
		Console.WriteLine("Peek after Pop(): {0}", hanoiTower.Peek);
	} else {
		Console.WriteLine("Empty after Pop()!");
	}
}

Console.WriteLine("Empty: {0}", hanoiTower.Empty);
// Console.WriteLine("Peek: {0}", hanoiTower.Peek);
Console.WriteLine("Contains(2): {0}", hanoiTower.Contains(2));
Console.WriteLine("Contains(7): {0}", hanoiTower.Contains(7));