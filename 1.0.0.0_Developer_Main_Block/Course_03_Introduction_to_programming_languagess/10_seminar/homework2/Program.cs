/*
Задача 2.
Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

"aBcD1ef!-" -> "abcd1ef!-"
*/


// В данном случае мы используем ASCII коды, чтобы определить, является ли символ заглавной буквой или нет. Заглавные буквы имеют ASCII коды от 65 ('A') до 90 ('Z'), а строчные буквы - от 97 ('a') до 122 ('z').

Console.Clear();

Console.Write("Введите строку: ");
string str = Console.ReadLine()!;
string result = "";

for (int i = 0; i < str.Length; i++)
{
    if (str[i] >= 'A' && str[i] <= 'Z')
    {
        result += (char)(str[i] + 32);
    }
    else
    {
        result += str[i];
    }
}

Console.WriteLine(result);
