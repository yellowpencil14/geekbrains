// Задание 1. Совместная работа
// Семинар 1. Знакомство с языками программирования
// Напишите программу, которая на вход принимает два целых числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

System.Console.WriteLine("Введите первое целое число");
int num1 = Convert.ToInt32( Console.ReadLine() );
System.Console.WriteLine("Введите второе целое число");
int num2 = Convert.ToInt32( Console.ReadLine() );
if (num1 == num2 * num2)
{
    System.Console.WriteLine("да");
}
else
    System.Console.WriteLine("нет");