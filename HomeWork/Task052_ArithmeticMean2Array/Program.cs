// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

//4. Метод определения среднего арифметического каждого столбца
void ArithmeticMean(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, j];
            }
            Console.Write($"{ sum / array.GetLength(0)}; ");
    }
}


Console.Clear();
Console.WriteLine("Задан массив:");
int[,] arr = CreateArray(10,10);
Fill(arr);
PrintArray(arr);
Console.Write($"Среднее арифметическое каждого столбца:");
ArithmeticMean(arr);