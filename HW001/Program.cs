// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число  ");
Console.WriteLine("x: ");
int x = Convert.ToInt32(Console.ReadLine());
int x1 = x % 100;
int x2 = x1 / 10;
Console.WriteLine (" " + x2);