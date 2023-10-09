int length = 10;
// https://learn.microsoft.com/en-us/dotnet/api/system.array?view=net-6.0
int[] array = new int[length];
Random rnd = new Random(1004084313);

for (int i = 0; i < array.Length; i += 1) {
	array[i] = rnd.Next(-1000, 1001);
}

// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement
foreach (int item in array) {
	Console.WriteLine(item);
}
Console.WriteLine();


int[] copy = new int[length];
int mid = length / 2;
// https://learn.microsoft.com/en-us/dotnet/api/system.array.copy?view=net-6.0#system-array-copy(system-array-system-int32-system-array-system-int32-system-int32)
Array.Copy(array, mid, copy, 0, length - mid);
Array.Copy(array, 0, copy, length - mid, mid);

for (int i = 0; i < length; i += 1) {
	Console.WriteLine("{0} {1}", array[i], copy[i]);
}
Console.WriteLine();


// https://learn.microsoft.com/en-us/dotnet/api/system.array.sort?view=net-6.0#system-array-sort(system-array)
Array.Sort(copy);
foreach (int item in copy) {
	Console.WriteLine(item);
}
Console.WriteLine();

// https://learn.microsoft.com/en-us/dotnet/api/system.array.reverse?view=net-6.0#system-array-reverse(system-array)
Array.Reverse(copy);
foreach (int item in copy) {
	Console.WriteLine(item);
}
Console.WriteLine();

// https://learn.microsoft.com/en-us/dotnet/api/system.array.clear?view=net-6.0#system-array-clear(system-array-system-int32-system-int32)
Array.Clear(copy, 4, 2);
foreach (int item in copy) {
	Console.WriteLine(item);
}
Console.WriteLine();