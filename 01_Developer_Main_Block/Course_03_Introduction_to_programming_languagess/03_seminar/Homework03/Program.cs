/*
Задача 3:
Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и
показывает наибольшую цифру числа.
*/

Console.Clear();

Console.Write("Введите число от 10 до 99: ");
int num = int.Parse(Console.ReadLine()!);
while (num < 10 || num > 99){
    Console.Write("Вы ошиблись!\nВведите число от 10 до 99: ");
    num = int.Parse(Console.ReadLine()!);
}

int n1 = num / 10;
int n2 = num % 10;

if (n1 > n2)
    Console.Write($"{n1} - наибольшая цифра числа {num}");
else if (n1 < n2)
    Console.Write($"{n2} - наибольшая цифра числа {num}");
else
    Console.Write($"Цифры равны: {n1} = {n2}");
