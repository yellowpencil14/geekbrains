﻿/*
Курс: Знакомство с языками программирования

Семинар от 05.02.2024
07
Урок 4
Функции

Дата: 15.02.2024
*/


/*
Ф. и процедуры (методы????)
Методы - это понятие допустимо только в ООП.
*/

// 1. Процедура ничего не возвращает, не принимает аргументы
// void f()
// {
//     Console.WriteLine("Hello, world!");
// }

// Console.Clear();
// f();

// 2. Процедура принимает аргументы
// void f(int n)
// {
//     n = n + 5;
// }

// int n = 10;
// f(n); // передача аргумента по значению
// Console.WriteLine(n); // выведет 10, т.к. передаётся только значение переменной.
//// n внутри процедуры и n в основном коде хранятся в разных ячейках памяти компьютера

// чтобы в этом коде вывело 15 и передать ссылку на ячейку, где хранится переменная n:

// void f(ref int n)
// {
//     n = n + 5;
// }

// int n = 10;
// f(ref n);
// Console.WriteLine(n); // выведет 15


// Ф. - обязаны (в отличие от процедур) возвращать какой-либо тип данных.


// // Задача. Выведите наибольшее число из 2-х.

// int getMax(int x, int y)
// {
//     if (x > y)
//         return x; // return возвращает значение туда, откуда была вызвана Ф. и моментально завершает работу Ф.
//     return y; // поэтому, если if НЕ выполняется, эта строка работает; а если выполняется if, то Ф. возвращает х и дальше (на данную строку кода не идёт). именно поэтому здесь можно не писать else 
// }

// Console.WriteLine(getMax(12, 18));
// Console.WriteLine(getMax(10, 1));
// Console.WriteLine(getMax(2, 20));
// Console.WriteLine(getMax(0, -3));

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/*
Задание 1

Задайте одномерный массив, заполненный случайными числами. 
Определите количество простых чисел в этом массиве.

Примеры
[1 3 4 19 3] => 2
[4 3 4 1 9 5 21 13] => 3
*/

// // процедура для заполнения массива случайными числами:
// void inputArray(int[] array) // если аргумент не переменная, а массив, передача ВСЕГДА происходит по ссылке (без ref)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 1001); // [1; 1000]
// }

// // n - простое число, если у него нет делителей без остатка в диапазоне [2; n/2]
// // Ф. проверки простое число или нет:
// bool isPrime(int x)
// {
//     for(int i = 2; i <= x / 2; i++)
//     {
//         if (x % i == 0)
//             return false;
//     }
//     return true;
// }

// // основной код всегда располагается после определения всех Ф.:

// Console.Clear();
// Console.Write("Введите количество элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);

// int[] array = new int[n];
// inputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

// Console.Write("Простые числа в массиве: ");

// // цикл foreach используется, когда не нужно изменять элементы массива. 
// // для этого используется цикл for (в нём мы обращаемся к элементам по индексам)

// foreach (int element in array) 
// {
//     if (isPrime(element)) // == true
//         Console.Write($"{element} ");
// }


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/*
Задание 2
Задайте массив из N случайных целых чисел (N вводится с клавиатуры).
Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.

Пример
[1 5 11 21 81 4 0 91 2 3]
=> 2
*/

// void inputArray(int[] array) // если аргумент не переменная, а массив, передача ВСЕГДА происходит по ссылке (без ref)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 1001); // [1; 1000]
// }


// Console.Clear();
// Console.Write("Введите количество элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);

// int[] array = new int[n];
// inputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

// int count = 0;
// foreach (int element in array) 
// {
//     if (element % 10 == 1 && element % 7 == 0)
//         count++;
// }
// Console.WriteLine($"В массиве оканчиваются на 1 и делятся нацело на 7: {count} чисел");


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


/*
Задание 3

Заполните массив на N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9.
Сформируйте целое число, которое будет состоять из цифр из массива.
Старший разряд числа находится на 0-м индексе, младший – на последнем.

Пример
[1 3 2 4 2 3] => 132423
[2 3 1] => 231
*/

void inputArray(int[] array) // если аргумент не переменная, а массив, передача ВСЕГДА происходит по ссылке (без ref)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 10); // [0; 9]
}


Console.Clear();
Console.Write("Введите количество элементов массива (не более 8): ");
int n = int.Parse(Console.ReadLine()!);
while (n > 8)
{
    Console.Write("Ошибка!\nВведите количество элементов массива (не более 8): ");
    n = int.Parse(Console.ReadLine()!);
}

int[] array = new int[n];
inputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

// целое_многозначное_число = первый_разряд*10^0 + второй_разряд*10^1 + третий_разряд*10^2 и т.д.
// создаём число из элементов массива:
int resultNumber = 0; // накопительная переменная для получения результата суммированием разрядов
int count = array.Length - 1; // степень возведения "десятки" для получения разряда. начинаем со старшего разряда
for (int i = 0; i < array.Length; i++)
{
    resultNumber += array[i] * Convert.ToInt32(Math.Pow(10, count)); // Math.Pow(10, count) -> 10^count (по умолчанию выдаёт double, поэтому делаем перевод в int)
    count--; // перебираем элементы массива, спускаясь от старшего разряда к младшему
}

Console.Write($"Число, которое состоит из цифр из массива: {resultNumber}");