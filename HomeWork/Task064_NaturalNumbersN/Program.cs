// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// 1. Метод ввода числа с клавиатуры
int ReadInt(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

// 2. Метод печати натуральных сисел (рекурсия)
void NaturalNumberPrint (int number)
{
    if (number < 0) Console.Write($"{number} не натуральное число");
    if (number == 0) return;
    Console.Write($"{number}, ");
    NaturalNumberPrint (number - 1);
}

int N = ReadInt("Введите число и нажмите Enter:");
NaturalNumberPrint (N);