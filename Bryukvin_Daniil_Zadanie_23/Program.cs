﻿//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= number)
{
    Console.Write($"{Math.Pow(i, 3)}, ");
    i++;
}
Console.WriteLine(" ");
