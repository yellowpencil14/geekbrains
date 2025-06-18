/*
Задачи из презентации к семинару.

Задача 1.
Задайте двумерный массив символов (тип char[,]). Создать строку из символов этого массива.

a	b	c	->	"abcdef"
d	e	f
*/

void inputMatrix(char[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			Console.Write("Введите символ: ");
			matrix[i, j] = char.Parse(Console.ReadLine()!);
		}
	}
}

void printMatrix(char[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			Console.Write($"{matrix[i, j]} \t");
		}
		Console.WriteLine();
	}
}


Console.Clear();
Console.Write("Введите размеры матрицы через пробел: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
char[,] matrix = new char[size[0], size[1]];
inputMatrix(matrix);
Console.WriteLine("Начальный массив: ");
printMatrix(matrix);

string result = "";
foreach (char element in matrix)
	result += element;
Console.WriteLine($"Строка из символов этого массива: {result}");
