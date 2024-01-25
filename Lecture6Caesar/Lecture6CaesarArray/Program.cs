Console.WriteLine("Zadejte plaintext:");
string plainText = Console.ReadLine();

int key;
bool success;
do {
	Console.WriteLine("Zadejte klíč:");
	success = int.TryParse(Console.ReadLine(), out key);
	if (!success) {
		Console.WriteLine("To není číslo!");
	}
} while (!success);

// chci key dostat mezi 0 a -25 (včetně)
key %= 26;               // key mezi -25 a 25
key += key < 0 ? 26 : 0; // -25..-1 se posune na 1..25, 0..25 zůstává

char[] cipherArray = plainText.ToCharArray();
for (int i = 0; i < cipherArray.Length; i += 1) {
	char plainChar = cipherArray[i];
	int cipherChar;

	if (plainChar >= 'A' && plainChar <= 'Z') {
		// (
		//   (
		//     plainChar // mezi 'A' a 'Z'
		//     - 'A'     // převeď na 0..25
		//     + key     // posun
		//   )
		//   % 26 // zpátky na 0..25
		// )
		// + 'A' // zpátky na 'A'..'Z'
		cipherChar = ((plainChar - 'A' + key) % 26) + 'A';
	} else if (plainChar >= 'a' && plainChar <= 'z') {
		cipherChar = ((plainChar - 'a' + key) % 26) + 'a';
	} else {
		cipherChar = plainChar;
	}

	cipherArray[i] = (char) cipherChar;
}


Console.WriteLine("Ciphertext:");
string cipherText = new string(cipherArray);
Console.WriteLine(cipherText);
