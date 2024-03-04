using Lecture20;

MyQueue<string> playlist = new MyQueue<string>();

Console.WriteLine("Empty: {0}", playlist.Empty);
// Console.WriteLine("Peek: {0}", playList.Peek);
Console.WriteLine("Contains(\"Under Pressure\"): {0}", playlist.Contains("Under Pressure"));
Console.WriteLine("Contains(\"Ice Ice Baby\"): {0}", playlist.Contains("Ice Ice Baby"));

playlist.Enqueue("Bohemian Rhapsody");
Console.WriteLine("Peek after Enqueue(\"Bohemian Rhapsody\"): {0}", playlist.Peek);

playlist.Enqueue("Don't Stop Me Now");
Console.WriteLine("Peek after Enqueue(\"Don't Stop Me Now\"): {0}", playlist.Peek);

playlist.Clear();

Console.WriteLine("Empty after Clear(): {0}", playlist.Empty);
// Console.WriteLine("Peek after Clear(): {0}", playList.Peek);
Console.WriteLine("Contains(\"Under Pressure\"): {0}", playlist.Contains("Under Pressure"));
Console.WriteLine("Contains(\"Ice Ice Baby\"): {0}", playlist.Contains("Ice Ice Baby"));

playlist.Enqueue("I Want to Break Free");
Console.WriteLine("Peek after Enqueue(\"I Want to Break Free\"): {0}", playlist.Peek);

playlist.Enqueue("Bicycle");
Console.WriteLine("Peek after Enqueue(\"Bicycle\"): {0}", playlist.Peek);

playlist.Enqueue("Under Pressure");
Console.WriteLine("Peek after Enqueue(\"Under Pressure\"): {0}", playlist.Peek);

playlist.Enqueue("We Will Rock You");
Console.WriteLine("Peek after Enqueue(\"We Will Rock You\"): {0}", playlist.Peek);

Console.WriteLine("Empty: {0}", playlist.Empty);
Console.WriteLine("Peek: {0}", playlist.Peek);
Console.WriteLine("Contains(\"Under Pressure\"): {0}", playlist.Contains("Under Pressure"));
Console.WriteLine("Contains(\"Ice Ice Baby\"): {0}", playlist.Contains("Ice Ice Baby"));

foreach (string song in playlist) {
	Console.WriteLine("foreach: {0}", song);
}

Console.WriteLine("Dequeue: {0}", playlist.Dequeue());
Console.WriteLine("Peek after Dequeue(): {0}", playlist.Peek);

Console.WriteLine("Dequeue: {0}", playlist.Dequeue());
Console.WriteLine("Peek after Dequeue(): {0}", playlist.Peek);

Console.WriteLine("Dequeue: {0}", playlist.Dequeue());
Console.WriteLine("Peek after Dequeue(): {0}", playlist.Peek);

playlist.Enqueue("We Will Rock You");
Console.WriteLine("Peek after Enqueue(\"We Will Rock You\"): {0}", playlist.Peek);

Console.WriteLine("Empty: {0}", playlist.Empty);
Console.WriteLine("Peek: {0}", playlist.Peek);
Console.WriteLine("Contains(\"Under Pressure\"): {0}", playlist.Contains("Under Pressure"));
Console.WriteLine("Contains(\"Ice Ice Baby\"): {0}", playlist.Contains("Ice Ice Baby"));

while (!playlist.Empty) {
	Console.WriteLine("Dequeue: {0}", playlist.Dequeue());
	if (!playlist.Empty) {
		Console.WriteLine("Peek after Dequeue(): {0}", playlist.Peek);
	} else {
		Console.WriteLine("Empty after Dequeue()!");
	}
}

Console.WriteLine("Empty: {0}", playlist.Empty);
// Console.WriteLine("Peek: {0}", playList.Peek);
Console.WriteLine("Contains(\"Under Pressure\"): {0}", playlist.Contains("Under Pressure"));
Console.WriteLine("Contains(\"Ice Ice Baby\"): {0}", playlist.Contains("Ice Ice Baby"));
