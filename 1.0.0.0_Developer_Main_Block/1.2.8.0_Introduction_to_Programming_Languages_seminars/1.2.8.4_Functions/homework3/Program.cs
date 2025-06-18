/*
Задача 3

Напишите программу, которая перевернёт одномерный массив
(первый элемент станет последним, второй – предпоследним и т.д.)
*/

void inputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 10);
}

void reverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}


Console.Clear();

Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);

int[] array = new int[n];
inputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

reverseArray(array);
Console.WriteLine($"Перевернутый массив: [{string.Join(", ", array)}]");
