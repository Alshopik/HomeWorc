// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
void SortToLower(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i,k] < array[i, k+1])
                {
                    int sort = array[i, k+1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = sort;
                }
            }
        }
    }
}

Console.Clear();
Console.WriteLine("Задан массив:");
int[,] arr = CreateArray(4,4);
Fill(arr);
PrintArray(arr);
SortToLower(arr);
Console.WriteLine("В итоге получается вот такой массива:");
PrintArray(arr);