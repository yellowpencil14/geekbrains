/*
Задачи из презентации к семинару.
Первые три задачи - дублируются в основном ДЗ (автотесты).

Задача 4.
Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. Под удалением понимается создание нового двумерного массива без строки и столбца.

Пример:
4	3	1	=>	2	6
2	6	9		4	6
4	6	2
*/


void inputMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
			matrix[i, j] = new Random().Next(1, 100); // от 1 до 99
	}
}

void printMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
			Console.Write($"{matrix[i, j]} \t");
		Console.WriteLine();
	}
}

// !!!!!!!!!!!!!!!!!!!дописать функцию полностью для поиска минимального элемента и формирования новой матрицы или же разбить на несколько функций:
void deleteRowColWithMinElement(int[,] matrix)
{
	int min = matrix[0, 0];
	foreach (int e in matrix)
	{
		if (e < min)
			min = e;
		return min; // нельзя так в void
	}
}


Console.Clear();

Console.Write("Введите размеры 2D массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray(); // Для ввода с клавиатуры размеров матрицы через пробел (см. 09_seminar\seminar)
int[,] matrix = new int[size[0], size[1]];

inputMatrix(matrix);
Console.WriteLine("\nНачальный массив: ");
printMatrix(matrix);

deleteRowColWithMinElement(matrix);

Console.WriteLine("\nКонечный массив: ");
printMatrix(matrix);
