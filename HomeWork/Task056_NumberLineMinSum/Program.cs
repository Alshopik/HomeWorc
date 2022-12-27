// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
// 4. Метод, который упорядочивает по убыванию элементы каждой строки двумерного массива
int NumberLineMinSum(int[,] array)
{
   int minSumLine = 0;
   int sumLine = 0;
   int numberMin = 0;
   for (int i = 0; i < array.GetLength(1); i++)
   {
        minSumLine += array[0,i];
   }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sumLine =+ array[i,j];
            if (sumLine < minSumLine)
            {
                minSumLine = sumLine;
                numberMin = i;
            }
            sumLine = 0;
        }
    return numberMin;
}

Console.Clear();
Console.WriteLine("Задан массив:");
int[,] arr = CreateArray(5,7);
Fill(arr);
PrintArray(arr);
Console.WriteLine($"Строка с наименьшей суммой элементов: {NumberLineMinSum(arr)+1} строка");