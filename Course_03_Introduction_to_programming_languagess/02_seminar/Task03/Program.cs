﻿// Задание 3*. Работа в сессионных залах
// Семинар 1. Знакомство с языками программирования
// Напишите программу, которая принимает на вход трёхзначное целое число и на выходе показывает 
// сумму первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0)
{
    num = num * (-1);
}


int i2 = num % 10;
while (num > 10)
{
    num = num / 10;
}

System.Console.WriteLine(num + i2);
