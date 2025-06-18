/*
Задача 4.
Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

"Hello my world" -> "world my Hello"
*/

Console.Clear();

Console.Write("Введите строку, состоящую из слов с пробелами: ");
string str = Console.ReadLine()!;

string[] words = str.Split(' '); // делаем из введенной строки массив из элементов string, в котором элементами являются слова строки (разделенные пробелом символы)

for (int i = 0; i < words.Length / 2; i++) // разворачиваем массив
{
	string temp = words[i];
	words[i] = words[words.Length - i - 1];
	words[words.Length - i - 1] = temp;
}

string reversedStr = string.Join(" ", words); // делаем обратно массив строкой, разделяя элементы пробелами

Console.Write($"Перевернутая строка: {reversedStr}");
