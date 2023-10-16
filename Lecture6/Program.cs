// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/
// https://docs.microsoft.com/en-us/dotnet/api/system.string?view=net-6.0

using System.Text;

string regular = "This is a string in double quotes.\nBackslashes (\\) have \"special\" meaning";
string concatenated = "I cannot write multiple line string literal," + "\n" +
	"but I can concat the string!";
string verbatim = @"This is a verbatim literal. Backslashes (\) have no special meaning. Double the ""quotes"" to escape them.
				It can have multiple lines, but the indents count.";
string formatted = String.Format("String.Format function works like {0}. It formats string with {1} or more arguments (like {0}).", "Console.WriteLine", 1);

Console.WriteLine(regular);
Console.WriteLine(concatenated);
Console.WriteLine(verbatim);
Console.WriteLine(formatted);
Console.WriteLine();


char[] charArray = { 'f', 'r', 'o', 'm', ' ', 'a', 'n', ' ', 'a', 'r', 'r', 'a', 'y' };
string fromArray = new string(charArray);
Console.WriteLine(fromArray);

char[] backToArray = fromArray.ToCharArray();
foreach (char c in backToArray) {
	Console.WriteLine(c);
}

// foreach (char c in fromArray) {
// 	Console.WriteLine(c);
// }

// for (int i = 0; i < fromArray.Length; i += 1) {
// 	Console.WriteLine(fromArray[i]);
// }

Console.WriteLine();

string str = "This is a test string. Příliš žluťoučký kůň úpěl ďábelské ódy.";

Console.WriteLine("str = {0}", str);
Console.WriteLine("str.ToLower() = {0}", str.ToLower());
Console.WriteLine("str.ToUpper() = {0}", str.ToUpper());
Console.WriteLine();

string strLess = "that is a test string. Příliš žluťoučký kůň úpěl ďábelské ódy.";
string strMore = "This is a test string. Příliš žluťoučký kůň úpěl ďábelské ódy..";
Console.WriteLine("str.CompareTo(\"{0}\") = {1}", str, str.CompareTo(str));
Console.WriteLine("str.CompareTo(\"{0}\") = {1}", str.ToLower(), str.CompareTo(str.ToLower()));
Console.WriteLine("str.CompareTo(\"{0}\") = {1}", strLess, str.CompareTo(strLess));
Console.WriteLine("str.CompareTo(\"{0}\") = {1}", str.ToUpper(), str.CompareTo(str.ToUpper()));
Console.WriteLine("str.CompareTo(\"{0}\") = {1}", strMore, str.CompareTo(strMore));
Console.WriteLine();

Console.WriteLine("str.Contains(\"{0}\") = {1}", "kůň", str.Contains("kůň"));
Console.WriteLine("str.Contains(\"{0}\") = {1}", "KŮŇ", str.Contains("KŮŇ"));
Console.WriteLine("str.IndexOf(\"{0}\") = {1}", "kůň", str.IndexOf("kůň"));
Console.WriteLine("str.IndexOf(\"{0}\") = {1}", "KŮŇ", str.IndexOf("KŮŇ"));
Console.WriteLine("str.IndexOf(\"{0}\") = {1}", " ", str.IndexOf(" "));
Console.WriteLine("str.LastIndexOf(\"{0}\") = {1}", "kůň", str.LastIndexOf("kůň"));
Console.WriteLine("str.LastIndexOf(\"{0}\") = {1}", "KŮŇ", str.LastIndexOf("KŮŇ"));
Console.WriteLine("str.LastIndexOf(\"{0}\") = {1}", " ", str.LastIndexOf(" "));
Console.WriteLine();

Console.WriteLine("str.Insert({0}, \"{1}\") = {2}", 49, "opravdu ", str.Insert(49, "opravdu "));
Console.WriteLine("str.Remove({0}, {1}) = {2}", 49, 9, str.Remove(49, 9));
Console.WriteLine("str.Substring({0}, {1}) = {2}", 49, 8, str.Substring(49, 8));
Console.WriteLine();

// many more, see documentation

string[] words = str.Split(' ');
foreach (string word in words) {
	Console.WriteLine(word);
}
Console.WriteLine();

Console.WriteLine(String.Join(", ", new string[] { "list", "of", "words" }));
Console.WriteLine();


string text = "this is a text";
for (int i = 0; i < text.Length; i += 1) {
	Console.Write(text[i]); // read-only
	// text[i] = 'x'; // does not compile
	Console.Write(' ');
}
Console.WriteLine("\n");

int two = 2;
double number = two; // can do
double pi = Math.PI;
// int engineeringPi = pi; // cannot do
int engineeringPi = (int) pi; // can do, but i lose information
Console.WriteLine("{0} {1} {2} {3}", two, number, pi, engineeringPi);

// int i = 'A'; can do
Console.WriteLine("Type-casting chars to ints: {0} {1} {2} {3}", (int) 'A', (int) 'Z', (int) 'a', (int) 'z');
// char c = 42; cannot do
// char c = (char) 42; can do
Console.WriteLine("Type-casting ints to chars: {0} {1} {2} {3}", (char) 0x41, (char) 0x5a, (char) 0x61, (char) 0x7a);
Console.WriteLine();

// https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder?view=net-6.0
StringBuilder strBuilder = new StringBuilder(str);
Console.WriteLine(strBuilder);

for (int i = 1; i < strBuilder.Length; i += 2) {
	strBuilder[i] = '*'; // does compile
}
strBuilder[strBuilder.Length - 1] = '@';
Console.WriteLine(strBuilder);

strBuilder.Remove(strBuilder.Length / 2, 10);
Console.WriteLine(strBuilder);

strBuilder.Append("..");

string finalStr = strBuilder.ToString();
Console.WriteLine(finalStr);