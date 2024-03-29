﻿/*
Курс: Знакомство с языками программирования

Лекция от 13.02.2024
11
Урок 5
Рекурсия

Дата: 05.03.2024
*/

/*
Рекурсия (Р.) - описание какого-либо объекта внутри этого самого объекта, то есть ситуация, когда объект является частью самого себя.
В программировании Р. - процесс, в котором функция вызывает саму себя.
Соответствующая функция называется рекурсивной.
Такой вызов называется рекурсивным вызовом.

Рекурсивный вызов:
- решает более простую (меньшую) задачу, чем текущая
- обычно достигается за счет упрощения (уменьшения) аргумента

Наименьшая из задач называется базовым случаем.

Условие остановки Р.:
- текущая задача стала тривиальной (об этом скажет значение параметра)
- рекурсивный вызов не требуется
- условие ставится перед рекурсивным вызовом
*/

// Пример с матрешкой:

// void openMatryoshka(int size)
// {
// 	if (size == 1)
// 	{
// 		Console.WriteLine("Reached the smallest matryoshka");
// 		return;
// 	}
// 	openMatryoshka(size - 1);
// 	Console.WriteLine($"Opening matryoshka of size {size}...");
// }

// openMatryoshka(5);

/*
Раскручивание Р. - процесс возврата к местам вызова функций.
В памяти сохраняются:
- места вызова функции (стек)
- значения параметров функции при вызове
*/

/*
Задача 1.
Вычислить факториал от натурального числа N.

N! = 1 * 2 * 3 * ... * N
*/

// int fact(int n)
// {
// 	if (n == 1 || n == 0)
// 		return 1;
// 	return n * fact(n - 1);
// }

// Console.Clear();
// Console.WriteLine(fact(5));


/*
Отладка программ.

Отладка - процесс поиска и исправления ошибок в программном коде.
- вывод текущего состояния программы
- использование отладчиков

Способы отладки программ.

1. Отладочная печать (вывод):
- на консоль
- в файл
*/

// int fact(int n)
// {
// 	if (n == 1 || n == 0)
// 	{
// 		Console.WriteLine($"Рекурсия остановилась при n = {n}"); // отладочный вывод значения параметра n, на котором рекурсия остановилась
// 		return 1;
// 	}
// 	Console.WriteLine(n); // консоль выдаст значения параметра n на каждой итерации рекурсии (это тоже отладочный вывод на экран)
// 	return n * fact(n - 1);
// }

// Console.Clear();
// Console.WriteLine($"Ответ: {fact(5)}");

/*
2. Выполнение кода построчно (запуск в режиме отладки).
Отладчик - программа, способная запустить код в особом режиме (режим отладки). В VS Code - расширение C# Dev Kit.
- пошаговое выполнение циклов
- просмотр значений переменных
- просмотр содержимого массива

Горячие клавиши отладчика (Debug Console):
- F11 - шаг с заходом
- F10 - шаг с обходом
- F5 - продолжить (до следующей точки)
*/


/*
Принципы разработки ПО:

1. DRY (Don't Repeat Yourself):
	- избегайте дублирования одинаковых фрагментов кода
	- задумайтесь об использовании функций для борьбы с дублированием
	- дублирование кода - пустая трата времени и ресурсов

2. KISS (Keep It Simple, Stupid) - не усложнять код без необходимости
	- простые системы будут работать лучше и надежнее
	- не придумывайте к задаче более сложного решения, чем ей требуется
	- простота кода - превыше всего, потому что простой код - наиболее понятный
	- непонятный код автоматически вызывает у человека ощущение того, что код сложный, так как его сложно понимать и модифицировать
	- "Управление сложностью - самый важный технический аспект разработки ПО" (Стив Макконнелл, "Совершенный код")

3. YANGI (You Aren't Gonna Need It) - отказ от ненужной функциональности
	- основная цель - отказ от избыточной функциональности
	- отказ добавления функциональности, в которой нет непосредственной надобности
	- если пишете код, то будьте уверены, что он вам понадобится
	- не пишите код, если думаете, что он пригодится позже
	- если вы занимаетесь рефакторингом, не бойтесь удалять лишние методы. Если они снова понадобятся, можно воспользоваться GIT-репозиторием
*/