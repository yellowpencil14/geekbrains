/*
Промежуточная аттестация.

Задача 2.
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Пример:
m = 2, n = 3 -> A(m,n) = 29
*/

int calculateAckermann(int n, int m)
{
	if (n == 0) // базовый случай
		return m + 1;
	else if (m == 0)
		return calculateAckermann(n - 1, 1);
	else
		return calculateAckermann(n - 1, calculateAckermann(n, m - 1));
}

Console.Clear();

Console.Write("Введите первое число (n): ");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число (m): ");
int num2 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"A(n, m) = {calculateAckermann(num1, num2)}"); // в примере дан неверный порядок переменных m и n. Я сделал задание согласно статье из Википедии.