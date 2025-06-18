/*
Курс: Знакомство с языками программирования

Семинар от 08.02.2024
09

Двумерные Массивы

Дата: 23.02.2024
*/



/*
Задача.
Сгенерируйте массив из n дробных чисел. Число n вводит пользователь.
*/

// void inputArray(double[] array)
// {
// 	for (int i = 0; i < array.Length; i++)
// 		array[i] = Math.Round(20 * new Random().NextDouble() - 10, 2);
// 		// NextDouble() - генерирует число в диапазоне (0; 1)
// 		// Math.Round(число, кол-во знаков после запятой) - округляет число (в нашем примере до 2 чисел после запятой)
// 		// Math.Round(1.4548152155452, 5) -> 1.45482 - до 5 знаков
// 		// х -> (0; 1) // по умолчанию этот диапазон для NextDouble, поэтому чтобы его изменить, необходимо выполнить нижеследующие действия
// 		// 20 * х -> (0; 20)
// 		// 20 * х - 10 -> (-10; 10)
// }

// Console.Clear();
// Console.Write("Введите количество элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// double[] array = new double[n]; // [0.0, 0.0, 0.0, ..., 0.0]
// inputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");



/*
Задание 1.

Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

Пример.
2	3	4	3		4	3	16	3
4	3	4	1	=>	4	3	4	1
2	9	5	4		4	9	25	4
*/


// void inputMatrix(int[,] matrix)
// {
// 	for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) - кол-во строк
// 	{
// 		for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) - кол-во столбцов
// 		{
// 			matrix[i, j] = new Random().Next(1, 11); // [1, 10]
// 		}
// 	}
// }

// void printMatrix(int[,] matrix)
// {
// 	for (int i = 0; i < matrix.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < matrix.GetLength(1); j++)
// 		{
// 			Console.Write($"{matrix[i, j]} \t");
// 			// \n - переход на новую строку
// 			// \t - табуляция
// 		}
// 		Console.WriteLine();
// 	}
// }

// void replaceElements(int[,] matrix)
// {
// 	for (int i = 0; i < matrix.GetLength(0); i+=2) // проходим только по чётным строкам
// 	{
// 		for (int j = 0; j < matrix.GetLength(1); j+=2) // проходим только по чётным столбцам
// 		{
// 			matrix[i, j] *= matrix[i, j];
// 		}
// 	}
// }


// Console.Clear();
// Console.Write("Введите размеры 2D массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray(); // Конструкция для ввода с клавиатуры пользователем размеров многомерного массива с разделением между значениями пробелом: "количество_строкПРОБЕЛколичество_столбцов".
// /*
// Расшифруем эту конструкцию по частям:
// 1. Console.ReadLine()! -> считывает введённые в терминал размеры 2-мерного массива. Например, "5 3", через пробел.
// 2. Split() -> в пустых скобках по умолчанию для этого метода аргументом является один пробел. Сам метод разделяет все части заданной строки, разделенные аргументом, на разные части. В данном случае - пробелом. Функция Split возвращает массив из частей строки. В нашем примере: ["5", "3"].
// 3. Select(x => int.Parse(x)) -> обращается к массиву ["5", "3"], обращается к каждому его элементу и конвертирует их из string в int. Возвращает элементы: 5 3.
// 4. ToArray() -> конвертирует эти элементы в массив типа int: [5, 3].
// */

// int[,] matrix = new int[size[0], size[1]];
// inputMatrix(matrix);
// Console.WriteLine("Начальный массив: ");
// printMatrix(matrix);
// replaceElements(matrix);
// Console.WriteLine("\nКонечный массив: ");
// printMatrix(matrix);



/*
Задание 2.

Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)

Пример.
2	3	4	3
4	3	4	1	=>	2 + 3 + 5 = 10
2	9	5	4

*/

// void inputMatrix(int[,] matrix)
// {
// 	for (int i = 0; i < matrix.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < matrix.GetLength(1); j++)
// 			matrix[i, j] = new Random().Next(1, 11);
// 	}
// }

// void printMatrix(int[,] matrix)
// {
// 	for (int i = 0; i < matrix.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < matrix.GetLength(1); j++)
// 			Console.Write($"{matrix[i, j]} \t");
// 		Console.WriteLine();
// 	}
// }

// int sumElements(int[,] matrix)
// {
// 	int x = matrix.GetLength(0);
// 	int y = matrix.GetLength(1);
// 	int result = 0;
// 	if (x < y)
// 	{
// 		for (int i = 0; i < x; i++)
// 			result += matrix[i, i];
// 	}
// 	else
// 	{
// 		for (int i = 0; i < y; i++)
// 			result += matrix[i, i];
// 	}
// 	return result;
// }


// Console.Clear();
// Console.Write("Введите размеры 2D массива: ");
// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();

// int[,] matrix = new int[size[0], size[1]];
// inputMatrix(matrix);
// Console.WriteLine("Начальный массив: ");
// printMatrix(matrix);
// Console.WriteLine($"Сумма элементов главной диагонали равна {sumElements(matrix)}");



/*
Задание 3.

Задайте двумерный массив из целых чисел. Сформируйте новый одномерный массив, состоящий из средних арифметических значений по строкам двумерного массива.

Пример.
2 3 4 3
4 3 4 1 => [3 3 5]
2 9 5 4
*/

void inputMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
			matrix[i, j] = new Random().Next(1, 11);
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

double[] searchAvg(int[,] matrix, double[] array)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		double sumRow = 0;
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			sumRow += matrix[i, j];
		}
		array[i] = Math.Round(sumRow / matrix.GetLength(1), 2);
	}
	return array;
}


Console.Clear();
Console.Write("Введите размеры 2D массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();

int[,] matrix = new int[size[0], size[1]];
double[] avgArray = new double[size[0]];


inputMatrix(matrix);
Console.WriteLine("Начальный массив: ");
printMatrix(matrix);
Console.WriteLine($"Среднее арифметическое каждой строки: [{string.Join(", ", searchAvg(matrix, avgArray))}]");
