// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// 1.Метод создания массива
int[,] CreateArray(int count1, int count2)
{
  return new int[count1,count2];
}
// 2.Метод заполнения двумерного массива случайными числами
void Fill(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1, 9);
            }
    }
}

// 3.Метод печати массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j], 3}");
            }
        Console.WriteLine();
    }
}

// 4.Метод ввода числа
int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

//5. Метод определения числа в массиве
void NumberInArray(int[,] array, int number)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i,j] == number) count++;
            }
    }
    if (count >= 1)
    Console.Write($"Число {number} присутствует в массиве");
    else 
    Console.WriteLine($"Числа {number} нет в массиве");
}


Console.Clear();
Console.WriteLine("Задан массив:");
int[,] arr = CreateArray(4,3);
Fill(arr);
PrintArray(arr);
int Number = ReadInt("Введите число и нажмите Enter: ");
NumberInArray(arr, Number);