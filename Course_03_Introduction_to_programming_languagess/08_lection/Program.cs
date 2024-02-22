/*
Курс: Знакомство с языками программирования

Лекция от 06.02.2024
08
Урок 4
Двумерные массивы

Дата: 18.02.2024
*/


/*
Двумерный массив (ДМ) - это массив, элементами которого являются одномерные массивы одинакового размера.

Другие названия ДМ:
- таблица
- матрица
- массив массивов

Характеристики ДМ:
- все свойства, присущие одномерным массивам (ОМ):
    - имеет имя для обращения
    - доступ осуществляется с помощью индексации []
    - имеет конечный размер
- в памяти хранится в виде ОМ, последовательно один за другим,
но при создании ДМ сообщаем компилятору тип данных ДМ, чтобы он работал с ним как с ДМ
- для обращения к элементу указывается:
    - имя ДМ // arroy
    - индекс ОМ (строки) // arroy[1]
    - индекс его элемента // arroy[1][3]
- размерность ДМ - количество измерений ДМ; количество индексов,
указываемое при обращении к элементу ДМ (1-мерный, 2-мерный, 3-мерный...)
*/



/*
Задача №1.

Создать ДМ с размерами 3х5, состоящий из целых чисел.
Вывести его элементы на экран.

Способ задания ДМ:
int[,] table = new int[3, 5];
    где int[,] - тип
        table - имя
        new int[3, 5] - выделение памяти
*/



// int[,] matrix = new int[3, 5];

// Random rnd = new Random();
// for (int i = 0; i < matrix.GetLength(0); i++) // GetLength(0) - запрашиваем количество строк ДМ matrix
// {
//     for (int j = 0; j < matrix.GetLength(1); j++) // GetLength(1) - запрашиваем количество столбцов ДМ matrix
//     {
//         // Random rnd = new Random(); // эта строка кода закомментирована и перенесена перед циклом for, т.к. объект rnd создаётся на каждой итерации, это очень ресурсоёмко. Вынесение её за пределы цикла не ломает логику алгоритма, но при этом экономит ресурсы компьютера
//         matrix[i, j] = rnd.Next(1, 11); // [1; 10]
//     }
// }

// // для вывода ДМ на экран (способ называется интерполяция строк):
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine(); // для вывода каждой строки ДМ на новой строке
// }


/*
Решим эту же задачу при помощи функций:
*/

// int[,] createMatrix (int rowCount, int columnCount)
// {
//     int[,] matrix = new int[rowCount, columnCount]; // здесь фиксированные 3 строки и 5 столбцов заменяем на аргументы функции, чтобы у пользователя была возможность изменить их при вызове

//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(1, 11);
//         }
//     }
//     return matrix;
// }

// void showMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// int[,] matrix = createMatrix(4, 5);
// showMatrix(matrix);



/*
Способы создания ДМ в C#

int[,] table1 = new int[2, 4] // в этом случае количество строк и столбцов можно не указывать (вместо "2, 4" указать просто ",")
{
    { 1, 1, 1, 1 },
    { 2, 2, 2, 2 }
};


int[,] table3 =
{
    { 1, 1, 1, 1 },
    { 2, 2, 2, 2 }
};

*/



/*
Задача №2.

Назовём число «интересным» если его сумма цифр чётная.
Создать двумерный массив, состоящий из целых чисел.
Вывести на экран «интересные» элементы массива.
*/

// int[,] createMatrix (int rowCount, int columnCount)
// {
//     int[,] matrix = new int[rowCount, columnCount];

//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(1, 1000);
//         }
//     }
//     return matrix;
// }

// bool isInteresting(int value)
// {
//     int sumOfDigits = getSumOfDigits(value);
//     if (sumOfDigits %2 == 0)
//         return true;
//     return false;
// }

// int getSumOfDigits(int value)
// {
//     int sum = 0;
//     while (value > 0)
//     {
//         sum = sum + value % 10;
//         value = value / 10;
//     }
//     return sum;
// }

// void showMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }



// int[,] matrix = createMatrix(3, 4);

// showMatrix(matrix);

// foreach (int e in matrix)
// {
//     if (isInteresting(e) == true)
//         Console.WriteLine(e);
// }



/*
Строки в C#

Строка - последовательный набор символов, который используется для представления текста.
Строка в языке C# - массив символов типа char.
Для работы со строками в C# используется специальный тип - string.


Характеристики строк:

- доступ к элементам строки может быть осуществлён операцией индексации
Пример.
string str = "Hello, world!";
Console.Write(str[0]); // -> H
Console.Write(str[1]); // -> e
    - элементы строки не могут быть изменены
    - размер существующей строки не может быть изменён


Создание строк в C#:

    Способ 1:
string s1 = "hello";

    Способ 2:
char[] ch_array = { 'w', 'o', 'r', 'l', 'd' };
string s2 = new String(ch_array); // String - конструктор строки. Конструктор - спец. метод, который создаёт объект

    Способ 3:
string s3 = new String('a', 6); // -> "aaaaaa"


Методы строк в C#:
- Contains - определяет, содержится ли подстрока в строке
- EndsWith - определяет, совпадает ли конец строки с подстрокой
- IndexOf - находит индекс первого вхождения символа или подстроки в строке
- Insert - вставляет в строку подстроку
- Replace - замещает в строке символ или подстроку другим символом или подстрокой
*/


/*
Задача №3

Считать с консоли строку, состоящую из цифр и латинских букв.
Сформировать новую строку, состоящую из букв исходной строки.
*/

// string getLetters(string s)
// {
//     string letters = "";
//     foreach (char e in s)
//     {
//         if (char.IsAsciiLetter(e) == true)
//         {
//             letters = letters + e;
//         }
//     }
//     return letters;
// }


// string str = Console.ReadLine()!;
// string result = getLetters(str);
// Console.WriteLine(result);


/*
Операторы передачи управления:

- break - прерывает выполнение ближайшего внешнего цикла (while, for, foreach).
    Часто используется, когда возникло условие, при котором цикл нужно немедленно прервать.
    Распространённый случай - остановка цикла с условием true (бесконечный цикл).
    Пример.
    while (true)
    {
        Console.WriteLine("I am in loop!");
        break;
    }

- continue - начинает новую итерацию ближайшего внешнего цикла (while, for, foreach).
    Часто используется, когда возникло условие, при котором оставшиеся инструкции тела цикла нужно пропустить.
    Пример.
    for (int i = 1; i < 5; i++)
    {
        Console.Write($"Iteration {i}: ");
        if (i == 3)
        {
            Console.WriteLine("Skip");
            continue;
        }
        Console.WriteLine("Some processing");
    }
*/