﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

int number = 22;

int count = 1;

Console.Write("Чётные числа от 1 до ");
Console.WriteLine(number);

while (count <= number)
{
    if (count % 2 == 0)
    {
        Console.Write(count);
        Console.Write("  ");
    }
    //count = count + 1;
    count++;
}