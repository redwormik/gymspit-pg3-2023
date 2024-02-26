using Lecture19;

MyLinkedList<int> numberList = new MyLinkedList<int>();

Console.WriteLine(numberList.Empty);
// Console.WriteLine(numberList.First);

Console.WriteLine(numberList.Contains(42));
Console.WriteLine(numberList.Contains(24));

numberList.AddLast(21);
numberList.AddLast(42);
numberList.AddLast(14);
numberList.AddLast(5);

Console.WriteLine(numberList.Empty);
Console.WriteLine(numberList.First);

Console.WriteLine(numberList.Contains(42));
Console.WriteLine(numberList.Contains(24));

numberList.RemoveFirst();

foreach (int number in numberList)
{
	Console.WriteLine(number);
}

numberList.Clear();
numberList.AddLast(24);
numberList.AddLast(24);
numberList.AddLast(0);

while (!numberList.Empty)
{
	Console.WriteLine(numberList.First);
	Console.WriteLine(numberList.Contains(42));
	Console.WriteLine(numberList.Contains(24));
	numberList.RemoveFirst();
}

Console.WriteLine(numberList.Empty);
// Console.WriteLine(numberList.First);

Console.WriteLine(numberList.Contains(42));
Console.WriteLine(numberList.Contains(24));


MyLinkedList<string> playlist = new MyLinkedList<string>();

Console.WriteLine(playlist.Empty);
// Console.WriteLine(playlist.First);

playlist.AddLast("How much is the fish?");
playlist.AddLast("Gangnam Style");
playlist.AddLast("Despacito");

Console.WriteLine(playlist.Empty);
Console.WriteLine(playlist.First);

Console.WriteLine(playlist.Contains("How much is the fish?"));
Console.WriteLine(playlist.Contains("Stánky"));

foreach (string song in playlist)
{
	Console.WriteLine(song);
}

playlist.RemoveFirst();

while (!playlist.Empty)
{
	Console.WriteLine(playlist.First);
	playlist.RemoveFirst();
}

Console.WriteLine(playlist.Empty);
// Console.WriteLine(playlist.First);