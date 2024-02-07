/*
Курс: Знакомство с языками программирования

Семинар от 01.02.2024
05
Урок 3
Массивы

Дата: 07.02.2024
*/


/*
Типы данных String, Char
*/

// Console.Clear();
// Console.Write("Введите имя: ");
// string name = Console.ReadLine()!;
// Console.WriteLine($"Привет, {name}!");

/*
Ivan // строка
0123 // индексы строки
Console.WriteLine(name[0]); // >> I -> аналогично массивам вывод на экран символа из строки по номеру индекса

name = "Ivan" -> string - двойные кавычки ""
name[0] = 'I' -> char - одинарные кавычки ''
*/

// Console.Clear();
// Console.Write("Введите число: ");
// string number = Console.ReadLine()!; // число подаётся как строка
// Console.WriteLine(Convert.ToInt32(number[0]));  // перевод типа данных char -> int.
//                                                 // При конвертации на выходе получится порядковый номер
//                                                 // первого символа "числа" в таблице символов UTF-8 в формате int
// Console.WriteLine(number[0] * 2);


// Console.WriteLine('A' > 'a'); // >>false, т.к. в char сравнение считается по таблице символов UTF-8. 'A' = 65, 'a' = 97

/*
Задача
Напишите программу, которая на вход принимает число и выводит сумму всех его цифр
*/

// Console.Clear();
// Console.Write("Введите число: ");
// string number = Console.ReadLine()!;
// // int number = int.Parse(Console.ReadLine()!); // переводить string в int не нужно
// int result = 0;
// for (int i = 0; i < number.Length; i++)
// {
//     result += int.Parse(number[i].ToString()); // корректно работает обходной путь char -> string -> int
// }
// Console.WriteLine(result);


/*
Массив (Array) и Список (List) - разные типы данных

Отличия:
    1. В массиве хранятся элементы ТОЛЬКО одного типа данных
    2. В списках - разные типы могут храниться одновременно
    3. Из-за этого массивы занимают меньше памяти и обрабатываются программой гораздо быстрее

data = [23, "Hello", -1.56, True]    -> пример списка в Python. Работать в Питоне с массивами можно,
                                        применяя библиотеки import array, import numpy
int[] data = {34, 56, 90, -10};      -> пример массива в C#

*/


/*
Задание 1

Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве. Программа
должна выдать ответ: Да/Нет.

Примеры
[1 3 4 19 3], 8 => Нет
[-4 3 4 1], 3 => Да 
*/


// Console.Clear();
// Console.Write("Введите количество элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// // создаётся массив размером n "нулей" [0, 0, ..., 0].
// // Или [0.0, 0.0, ..., 0.0], если тип double
// // Или ["", "", ..., ""], если тип string

// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(-10, 11); // [-10; 10]
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

// Console.Write("Введите искомый элемент: ");
// int element = int.Parse(Console.ReadLine()!);
// string result = "Нет";

// for (int i = 0; i < array.Length; i++)
//     if (array[i] == element)
//         result = "Да";

// Console.WriteLine(result);


/*
Задание 2

Задайте массив из 10 элементов, заполненный числами из
промежутка [-10, 10]. Замените отрицательные элементы на
положительные, а положительные на отрицательные.

Пример
[1 -5 6]
=> [-1 5 -6]
*/

// Console.Clear();
// int[] array = new int[10];

// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(-10, 11); // [-10; 10]
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

// for (int j = 0; j < array.Length; j++)
//     array[j] = array[j] * (-1); // или array[j] *= -1;
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");


/*
Задание 3

Найдите произведения пар чисел в одномерном массиве. Парой
считаем первый и последний элемент, второй и предпоследний и
т.д. Результат запишите в новый массив.

Пример
[1 3 2 4 2 3] => [3 6 8]
[2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)
*/

// Console.Clear();
// Console.Write("Введите количество элементов массива: ");
// int size = int.Parse(Console.ReadLine()!);
// int[] array = new int[size];

// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(-10, 11); // [-10; 10]
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

// int[] resultArray = new int[array.Length / 2];

// for (int j = 0; j < (array.Length / 2); j++)
//     resultArray[j] = array[j] * array[array.Length -1 - j]; // первый и последний элемент и дальше зеркально к центру
// Console.WriteLine($"Конечный массив: [{string.Join(", ", resultArray)}]");


/*
Задание 4
Дано натуральное трёхзначное число. Создайте массив, состоящий из цифр этого числа.
Младший разряд числа должен располагаться на 0-м индексе массива, старший – на 2-м.

Пример
456 => [6 5 4]
781 => [1 8 7]
*/

Console.Clear();
int n = 456;
int[] array = new int[3];
array[0] = n % 10;
array[1] = (n % 100) / 10;
array[2] = n / 100;
Console.WriteLine($"[{string.Join(" ", array)}]");
