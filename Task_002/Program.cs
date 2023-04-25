// Задача №2
// Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3
// 1. Принять два числа;
// 2. Определить max и mini среди двух чисел;
// 4. Вывести число;

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Перове число max");
    Console.WriteLine("Второе число mini");
}
else
{
    Console.WriteLine("Первое число mini");
    Console.WriteLine("Второе число max");
}
Console.WriteLine();



