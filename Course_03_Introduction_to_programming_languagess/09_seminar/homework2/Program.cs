/*
Задачи из раздела "Задания" (автотесты).

Задача 2.

Поменяйте местами первую и последнюю строку массива.

Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Начальные условия:
int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
}; 

Выводится:
9   10  11  12
5   6   7   8
1   2   3   4
*/


using System;

// Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    // Печать массива
    public static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write($"{array[i, j]}\t");
            Console.WriteLine();
        }
    }

// Обмен первой с последней строкой
    public static int[,] SwapFirstLastRows(int[,] array)
    {
        // Напишите свое решение здесь
        for (int i = 0; i < array.GetLength(1); i++)
        {
            int temp = array[0, i];
            array[0, i] = array[array.GetLength(0) - 1, i];
            array[array.GetLength(0) - 1, i] = temp;
        }
        return array;
    }

// Обмен элементами массива
    public static void SwapItems(int[,] array, int i)
    {
        // Напишите свое решение здесь
        if (i < array.GetLength(0) - 1 && i >= 0)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                int temp = array[i, j];
                array[i, j] = array[i + 1, j];
                array[i + 1, j] = temp;
            }
        }
        else
            Console.WriteLine("Индекс выходит за пределы массива");
    }

    public static void PrintResult(int[,] numbers)
    {
        // Напишите свое решение здесь
        int[,] swappedArray = SwapFirstLastRows(numbers);
        PrintArray(swappedArray);
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[,] numbers;

        if (args.Length >= 1)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            numbers = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        numbers[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }
        }
        else
        {
            // Если аргументов на входе нет, используем примерный массив
            numbers = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            }; 
        }
        UserInputToCompileForTest.PrintResult(numbers);
    }
}