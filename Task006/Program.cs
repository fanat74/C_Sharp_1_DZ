﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите натуральное число отличное от нуля");
int number = Convert.ToInt32(Console.ReadLine());
if (number==0) 
{
Console.WriteLine("Неверный ввод");
}

else if (number%2==0)
{
    Console.WriteLine($"Число {number} является четным");
}
else
{
     Console.WriteLine($"Число {number} является нечетным");
}