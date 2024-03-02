/*
Курс: Знакомство с языками программирования

Семинар от 12.02.2024
10

Массивы и строки

Дата: 02.03.2024
*/


// int[] arrayInt = new int[5]; // [0, 0, 0, 0, 0]
// string[] arrayString = new string[5]; // ["", "", "", "", ""]
// char[] arrayChar = new char[5]; // ['', '', '', '', '']


/*
Задание 1.
Задайте массив символов (тип char []). Создайте строку из символов этого массива.

Указание
Конструктор строки вида string(char []) не использовать.

Пример
['a', 'b', 'c', 'd'] -> "abcd"
*/

// Console.Clear();
// Console.Write("Введите количество элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// char[] chars = new char[n];
// for (int i = 0; i < chars.Length; i++)
// {
// 	Console.Write("Введите символ: ");
// 	chars[i] = char.Parse(Console.ReadLine()!);
// }
// Console.WriteLine($"Начальный массив: [{string.Join(", ", chars)}]");

// // первый вариант преобразования массива chars в строку:
// Console.WriteLine(string.Join("", chars));

// // второй вариант преобразования массива chars в строку:
// string result = "";
// foreach (char element in chars)
// 	result += element;
// Console.WriteLine(result);



/*
Задание 2. (Обратная первой)
На основе символов строки (тип string) сформировать массив символов (тип char[]). Вывести массив на экран.

Указание:
Метод строки ToCharArray() не использовать.

Пример:
"Hello!" -> ['H', 'e', 'l', 'l', 'o', '!']
*/

// Console.Clear();
// Console.Write("Введите строку: ");
// string str = Console.ReadLine()!;
// char[] chars = new char[str.Length];
// for (int i = 0; i < chars.Length; i++)
// {
// 	chars[i] = str[i];
// }
// Console.WriteLine($"Искомый массив: [{string.Join(", ", chars)}]");



/*
Задание 3.
Считать строку с консоли, состоящую из латинских букв в нижнем регистре. Выяснить, сколько среди введённых букв гласных.

Пример:
"hello" -> 2
"world" -> 1
*/

bool isVowel(char ch, char[] vowels)
{
	foreach (char element in vowels)
	{
		if (element == ch)
			return true;
	}
	return false;
}


Console.Clear();
Console.Write("Введите строку: ");
string str = Console.ReadLine()!;
char[] vowels = { 'a', 'e', 'o', 'i', 'y', 'u' };
int count = 0;
for (int i = 0; i < str.Length; i++)
{
	if (isVowel(str[i], vowels))
		count++;
}
Console.WriteLine($"Количество гласных букв в строке: {count}");
