﻿//Задача №4
//Напишите программу, которая принимает на вход три числа и выдает максимальное
// из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

// 1. Принять три числа
// 2. Сравнить три числа
// 3. Определить максимальное
// 4. Вывести маскимальное число

Console.WriteLine("Введите три числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;

Console.Write("max "); 
Console.WriteLine(max);

// Для себя:
// попробовать другие способы решения, например, используя массивы.







