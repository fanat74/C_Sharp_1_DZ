﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int max=0;
Console.WriteLine("Введите первое натуральное число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье натуральное число");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    max=numberA;
}
else
{
    max=numberB;
}
if (numberC > max)
{
    max=numberC;
}
Console.WriteLine($"Максимальное число это {max}");