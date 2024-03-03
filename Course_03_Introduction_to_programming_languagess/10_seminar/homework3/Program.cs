/*
Задача 3.
Задайте произвольную строку. Выясните, является ли она палиндромом.

"aBcD1ef!-" -> Нет
"шалаш" -> Да
"55655" -> Да
*/

Console.Clear();

Console.Write("Введите строку: ");
string str = Console.ReadLine()!;

int result = 0;
for (int i = 0; i < str.Length / 2; i++)
{
	if (str[i] == str[str.Length - i - 1])
	{
		result += 1;
	}
}

if (result > 0)
	Console.Write("Строка является палиндромом");
else
	Console.Write("Строка не является палиндромом");