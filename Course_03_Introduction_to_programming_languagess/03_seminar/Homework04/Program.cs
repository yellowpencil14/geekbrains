﻿/*
Задача 4:
Напишите программу, которая на вход принимает натуральное число N,
а на выходе показывает его цифры через запятую.
*/


Console.Clear();

Console.Write("Введите натуральное число N: ");
int num = int.Parse(Console.ReadLine()!);
while (num < 1){
    Console.Write("Вы ошиблись!\nВведите натуральное число N: ");
    num = int.Parse(Console.ReadLine()!);
}

while (num > 0){
    Console.Write($"{num % 10}, ");
    num = num / 10;
}


/*
НИЖЕ ОКОНЧАНИЕ КОДА ИЗ ДОКУМЕНТА ПО ССЫЛКЕ С "ИДЕАЛЬНЫМ РЕШЕНИЕМ".
МОЙ КОД (ВЫШЕ) КОРОЧЕ. РАЗНИЦА В ВЫВОДЕ ТОЛЬКО В ЗАПЯТОЙ НА КОНЦЕ.
В УСЛОВИИ НЕ УКАЗАНО, НО МНЕ ПРЕДСТАВЛЯЛСЯ ПРАВИЛЬНЫЙ ВЫВОД ЦИФР ВСЁ ЖЕ В ТОМ ЖЕ ПОРЯДКЕ, ЧТО В ИСХОДНОМ ЧИСЛЕ.
ЭТО Я ТОЖЕ НЕ ПРИДУМАЛ КАК ВОПЛОТИТЬ ЧЕРЕЗ ЦИКЛ.
НО, ЕСЛИ ТАКОЙ ВЫВОД ПОДОЙДЁТ, СПОРИТЬ НЕ БУДУ, ЭТО ДЕЙСТВИТЕЛЬНО НЕ ОБОЗНАЧЕНО В УСЛОВИИ ЗАДАЧИ, ПРОСТО ЛОГИЧЕСКИ НАПРАШИВАЕТСЯ.
ОДНАКО, ЗАДАЧА ИНТЕРЕСНАЯ, ХОТЕЛОСЬ БЫ УВИДЕТЬ РАЗБОР РЕШЕНИЯ С ВЫВОДОМ НЕ РАЗВЕРНУТОГО ЗАДОМ НАПЕРЁД ПОРЯДКОМ ЦИФР =)
*/


// if (num < 10)
//     Console.Write(num);
// else{
//     while (num > 0){
//         int currentDigit = num % 10;
//         num /= 10;
//         if (num > 0){
//             Console.Write(currentDigit + ",");
//         }
//         else{
//             Console.WriteLine(currentDigit);
//         }
//     }
// }
