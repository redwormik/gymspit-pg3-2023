static int[] GenerateIntArray(int length, int seed, int max)
{
	Random rng = new Random(seed);
	int[] array = new int[length];
	for (int i = 0; i < array.Length; i++) {
		array[i] = rng.Next(max);
	}
	return array;
}


static void PrintIntArray(int[] array)
{
	foreach (int item in array) {
		Console.WriteLine(item);
	}
	Console.WriteLine();
}


static void SelectionSortInt(int[] array)
{
	for (int i = 0; i <	array.Length - 1; i += 1) {
		int min = i;

		for (int j = i + 1; j < array.Length; j += 1) {
			if (array[j] < array[min]) {
				min = j;
			}
		}

		if (i != min) {
			int tmp = array[i];
			array[i] = array[min];
			array[min] = tmp;
		}
	}
}


static void SelectionSortIntString(int[] keys, string[] values)
{
	for (int i = 0; i < keys.Length - 1; i += 1) {
		int min = i;

		for (int j = i + 1; j < keys.Length; j += 1) {
			if (keys[j] < keys[min]) {
				min = j;
			}
		}

		if (i != min) {
			int tmp = keys[i];
			keys[i] = keys[min];
			keys[min] = tmp;

			string tmpValue = values[i];
			values[i] = values[min];
			values[min] = tmpValue;
		}
	}
}


static void InsertionSortInt(int[] array)
{
	for (int i = 1; i < array.Length; i++) {
		int tmp = array[i];
		int j = i;

		while (j > 0 && array[j - 1] > tmp) {
			array[j] = array[j - 1];
			j -= 1;
		}

		if (j != i) {
			array[j] = tmp;
		}
	}
}


static void BubbleSortInt(int[] array)
{
	// TODO
}


int length = 12;
int seed = 1811;
int max = 100;
int[] array;

Console.WriteLine("SelectionSort");
array = GenerateIntArray(length, seed, max);
PrintIntArray(array);
SelectionSortInt(array);
PrintIntArray(array);

Console.WriteLine("InsertionSort");
array = GenerateIntArray(length, seed, max);
PrintIntArray(array);
InsertionSortInt(array);
PrintIntArray(array);

//Console.WriteLine("BubbleSort");
//array = GenerateIntArray(length, seed, max);
//PrintIntArray(array);
//BubbleSortInt(array);
//PrintIntArray(array);