/*
Промежуточная аттестация.

Задача 3.
Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

Пример:
[1, 2, 5, 0, 10, 34] -> 34 10 0 5 2 1 
*/

string reverseArray(int[] array, int i = 0)
{
	if (i == array.Length) // базовый случай
		return "";
	return reverseArray(array, i + 1) + $"{array[i]} ";
}

Console.Clear();

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] arr = new int[size];
for (int i = 0; i < arr.Length; i++)
    arr[i] = new Random().Next(1, 21); // заполняем рандомными числами [1; 20]. Надеюсь, использование цикла для заполнения элементов массива не будет считаться ошибкой, ведь основная функция разворота его элементов в обратном порядке реализована с применением рекурсии

Console.WriteLine($"Начальный массив: [{string.Join(", ", arr)}]");

Console.WriteLine($"Элементы в обратном порядке: {reverseArray(arr)}");
