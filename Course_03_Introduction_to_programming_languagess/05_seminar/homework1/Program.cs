/*
Задачи из раздела "Задания" (автотесты).

Задача 1.

Количество элементов массива на отрезке.

Задайте одномерный массив из 10 целых чисел от 1 до 100.
Найдите количество элементов массива,
значения которых лежат в отрезке [10,90].

Начальные условия:
int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива

Выводится: 5
*/

using System;
using System.Linq;

// Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Подсчет количества элементов массива, попадающих в заданный диапазон
    // numbers - массив, в котором ведется подсчет
    // minRange - минимальная граница диапазона
    // maxRange - максимальная граница диапазона
    public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
    {
        //Введите сюда свое решение
        int count = 0;

        foreach (int number in numbers)
            if (number >= minRange && number <= maxRange)
                count++;

        return count;
    }
    
    public static void PrintResult(int[] array)
    {
        //Введите сюда свое решение
        int minRange = 10;
        int maxRange = 90;

        int count = CountItemsRange(array, minRange, maxRange);

        Console.WriteLine(count);
    }

}


//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[] array;
        

        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(int.Parse)
                                  .ToArray();
            
            // Теперь arr содержит преобразованные в целые числа из командной строки
        
        } else {
           // Если аргументов на входе нет
            array = new int[] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}