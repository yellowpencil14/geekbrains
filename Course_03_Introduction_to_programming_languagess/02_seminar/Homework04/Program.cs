// Вывести четные числа
// Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number),
// а на выходе выводит все чётные числа от 1 до number (включительно), после каждого числа должен быть знак пробела.

// 1. На входе:
// number = 5 
// На выходе:
// 2 4 
// 2. На входе:
// number = 8 
// На выходе:
// 2 4 6 8

using System;

public class Answer {
    static void PrintEvenNumbers(int number)
    {
        // Введите свое решение ниже
        int i = 2;
        while (number > i)
        {
            System.Console.Write(i + " ");
            i = i + 2;
        }
        if (number % 2 == 0)
        {
            System.Console.Write(number);
        }
    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 16;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}