﻿//Задача №8
//Напишите программу, которая на вход принимает число (N), а на выходе показывает 
// все четные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int a = 2;

if(N > 1)
    while (a <= N)
    {
        Console.Write(a + " ");
        a += 2;
    }
    Console.Write("Чётные числа");