//19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();

int number = new Random().Next(10000, 99999);           //случайное пятизначное число  
//int number = 12821;                                  //ручная проверка

int first = number / 10000 % 10;
int second = number / 1000 % 10;
int fourth = number / 10 % 10;
int fifht = number % 10;                       // % 10 - остаток от деления на 10 - это последняя цифра числа

if (first == first && second == fourth)       // палидром  — число, буквосочетание, слово или текст, одинаково читающееся в обоих направлениях
{
    Console.WriteLine($"Число {number} является палидромом");   // ДА - является палидромом
}
else
{
Console.WriteLine($"Число {number} не является палидромом");   // НЕТ - не является палидромом
}

// Console.WriteLine(number);

// Console.WriteLine(first);
// Console.WriteLine(second);
// Console.WriteLine(fourth);
// Console.WriteLine(fifht);