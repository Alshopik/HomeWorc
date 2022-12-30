// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// 1. Метод ввода числа с клавиатуры
int ReadInt(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

// 2. Метод суммы натуральных числе (рекурсия)
void SumNaturalNumber (int number1, int number2, int sum)
{
        if (number1 > number2) 
    {
        Console.Write($"Cумма натуральных элементов в промежутке введенных чисел: {sum}");
        return;
    }
    sum = sum + (number1++);
    SumNaturalNumber (number1, number2, sum);
}

int M = ReadInt("Введите число M и нажмите Enter:");
int N = ReadInt("Введите число N и нажмите Enter:");
SumNaturalNumber (M, N, 0);