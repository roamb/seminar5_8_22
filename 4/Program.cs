﻿Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 2;
while (current <= num)
{
    Console.Write(current + " ");
    current = current + 2;
}