/*
Промежуточная аттестация.

Задача 1.
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


Пример:
M = 1; N = 5 -> "1 2 3 4 5"
M = 4; N = 8 -> "4 5 6 7 8"
*/

string printNumbers(int num1, int num2)
{
	if (num1 > num2) // чтобы поменять числа местами, если нужно 
	{
		int temp = num2;
		num2 = num1;
		num1 = temp;
	}
	if (num2 == num1) // базовый случай
		return $"{num1} ";
	return printNumbers(num1, num2 - 1) + $"{num2} ";
}

Console.Clear();

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);

Console.WriteLine(printNumbers(num1, num2));
