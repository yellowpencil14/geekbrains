﻿/*
Транслятор.
Виды трансляции:
** Компиляция
** Интерпретация

C#: int n = 5; -> []
Python: m = -10 -> class 'int' -> []
*/

/*
Основные типы данных
1. Integer (int) - 0, -12, 56, 90
2. double - 2.0, 56.923. -1.345
3. boolean (bool) - true, false
4. string - "Anna", "Moscow" (строка обозначается двойными ковычками)
5. char - 'a', 'c', 'e', '5' (символы)
*/

// Принимаем данные от пользователя
// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!); // Второй способ. Он лучше. Создается только одна ячейка
// Console.Write("Введите 2-ое число: ");
// int m = Convert.ToInt32(Console.ReadLine()); // Первый способ. Создаются две ячейки
// Console.WriteLine($"{n} + {m} = {n + m}");

/*
Первый способ
int m = Convert.ToInt32(Console.ReadLine());
Console.ReadLine() -> считывание данных из консоли -> []
int m = Convert.ToInt32("456"); -> [456]
int m = 456;
*/

/*
Второй способ
int n = int.Parse(Console.ReadLine()!);
Console.ReadLine() -> считывание данных из консоли -> ["456"]
int n = int.Parse("456") -> ["456"] -> [456]
*/

// Найдите максимальное число из 2-х.
// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int m = int.Parse(Console.ReadLine()!);
// if (n > m){
//     Console.WriteLine($"{n} больше {m}");
// }
// else if (n < m)
//     Console.WriteLine($"{m} больше {n}");
// else
//     Console.WriteLine("Числа равны");

/*
Алгебра логики (Булевская)
True -> 1
False -> 0

&& - конъюнкция - логическое умножение - "И":
1 && 1 = 1
1 && 0 = 0
0 && 1 = 0
0 && 0 = 0

|| - дизъюнкция - логическое сложение - "ИЛИ":
1 || 1 = 1
1 || 0 = 1
0 || 1 = 1
0 || 0 = 0

*/

/*
Задание 1. Совместная работа
Напишите программу, которая принимает на вход
трёхзначное число и удаляет вторую цифру этого
числа.
Примеры
a = 256 => 26
a = 891 => 81
*/

// Console.Clear();
// Console.Write("Введите 3-х значное число: ");
// int n = int.Parse(Console.ReadLine()!);
// n = Math.Abs(n); // модуль числа
// while (n < 100 || n > 999){
//     Console.Write("Вы ошиблись!\nВведите 3-х значное число: ");
//     n = int.Parse(Console.ReadLine()!);
// }
// int n1 = n / 100;
// int n3 = n % 10; // 523 : 10 = 52 (ост. 3)
// Console.WriteLine(n1 * 10 + n3);
// Console.WriteLine($"{n1}{n3}"); // хитрый вариант


/*
Задание 2. Работа в сессионных залах
Напишите программу, которая принимает на вход трёхзначное
число и возводит вторую цифру этого числа в степень, равную
третьей цифре.
Примеры
487 => 8^7 = 2 097 152
254 => 5^4 = 625
617 => 1
*/

// Console.Clear();
// Console.Write("Введите 3-х значное число: ");
// int n = int.Parse(Console.ReadLine()!);
// n = Math.Abs(n); // модуль числа
// while (n < 100 || n > 999){
//     Console.Write("Вы ошиблись!\nВведите 3-х значное число: ");
//     n = int.Parse(Console.ReadLine()!);
// }
// int n1 = n / 100;
// int n2 = (n / 10) % 10; // 523 : 10 = 52 (ост. 3), 52 : 10 = 5 (ост. 2)
// int n3 = n % 10; // 523 : 10 = 52 (ост. 3)
// int result = 1;
// for (int i = 0; i < n3; i++) // n3 раз
//     result *= n2; // result = result * n2
// Console.WriteLine($"{n2} ^ {n3} = {result}");


/*
Задание 3. Работа в сессионных залах
Напишите программу, которая будет принимать на вход два
числа и выводить, является ли второе число кратным первому.
Если второе число некратно первому, то программа выводит
остаток от деления.
Примеры
14, 5 => нет, 4
16, 8 => да
4, 3 => нет, 1
*/

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int n2 = int.Parse(Console.ReadLine()!);
// if (n1 % n2 == 0)
//     Console.WriteLine($"да");
// else
//     Console.WriteLine($"нет, {n1 % n2}");


/*
Задание 4. Работа в сессионных залах
Напишите программу, которая выводит третью с конца
цифру заданного числа или сообщает, что третьей цифры
нет.
456 => 6
7812 => 8
91 => Третьей цифры нет
*/

Console.Clear();
Console.Write("Введите целое число: ");
int n = int.Parse(Console.ReadLine()!);
if (n < 100)
    Console.WriteLine($"Третьей цифры нет");
else
    Console.WriteLine($"{(n / 100) % 10}");
