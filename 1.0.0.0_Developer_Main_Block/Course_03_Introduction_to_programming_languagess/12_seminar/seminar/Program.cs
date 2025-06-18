/*
Курс: Знакомство с языками программирования

Семинар от 15.02.2024
12

Рекурсия

Дата: 08.03.2024
*/

/*
Напишите программу, которая складывает 2 числа без прямого сложения.
*/

// int sumNumbers(int a, int b)
// {
// 	if (b == 0) // точка остановки рекурсии
// 		return a;
// 	return sumNumbers(a + 1, b - 1);
// }

// /*
// f = sumNumbers
// f(5, 3) -> f(6, 2) -> f(7, 1) -> f(8, 0) -> 8
// f(5, 3) <- f(6, 2) <- f(7, 1) <- f(8, 0) <- 8
// */

// Console.Clear();

// Console.Write("Введите 1-е число: ");
// int a = int.Parse(Console.ReadLine()!);

// Console.Write("Введите 2-е число: ");
// int b = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"{a} + {b} = {sumNumbers(a, b)}");


/*
Задание 1.
Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. Использовать рекурсию.

Пример:
123 => 6
63 => 9
*/

// int sumDigits(int number)
// {
// 	if (number / 10 == 0 || number % 10 == number) // точка остановки рекурсии. НЕПОНЯТНО НАХЕРА ТАКОЕ УСЛОВИЕ. можно ж просто условие (number < 10) и всё так же точно работает!!! рекурсия останавливается когда число становится однозначным
// 		return number;
// 	return sumDigits(number / 10) + number % 10;
// }

// Console.Clear();

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"Сумма цифр равна {sumDigits(number)}");


/*
Задание 2.
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. Использовать рекурсию. Не использовать цикл.

Пример:
N=5 -> 1 2 3 4 5
*/

// string printNumbers(int number)
// {
// 	if (number == 1)
// 		return "1 ";
// 	return printNumbers(number - 1) + $"{number} "; // если слагаемые поставить наоборот, результат будет наизнанку - "5 4 3 2 1 ". Для верного результата в таких моментах важен приоритет выполнения операций программой
// }

// Console.Clear();

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);

// Console.WriteLine(printNumbers(number)); // в результате будет "1 2 3 4 5 "


/*
Задание 3.
Считать строку с консоли, содержащую латинские буквы. Вывести на экран согласные буквы этой строки. Использовать рекурсию. Не использовать цикл.

Пример:
"hello" -> h l l
"World" -> W r l d
"Hello world!" -> H l l w r l d
*/

string printConsonants(string n, int i)
{
	if (i == n.Length)
		return "";
	else
	{
		if (n[i] == 'a' || n[i] == 'e' || n[i] == 'i' || n[i] == 'o' || n[i] == 'u' || n[i] == 'y')
			return printConsonants(n, i + 1);
		return $"{n[i]}" + printConsonants(n, i + 1);
	}
}

Console.Clear();

Console.Write("Введите строку: ");
string str = Console.ReadLine()!;

Console.WriteLine(printConsonants(str, 0));
