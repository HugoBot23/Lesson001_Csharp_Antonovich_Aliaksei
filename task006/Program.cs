﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Решение.

Console.WriteLine("Введите пожалуста число");
int numberA = int.Parse(Console.ReadLine());

if (numberA % 2 == 0)
  Console.WriteLine("Число является четным " + numberA);
else
  Console.WriteLine("Число не четное " + numberA);