// 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();

int number = new Random().Next(100, 1000);           //случайное трехзначное число  
//int number = 918;                                  //ручная проверка
int second = number / 10 % 10;                       // % 10 - остаток от деления на 10 - это последняя цифра числа

Console.Write("Второй цифрой числа ");
Console.Write(number);
Console.Write(" является ");
Console.Write(second);
Console.WriteLine();