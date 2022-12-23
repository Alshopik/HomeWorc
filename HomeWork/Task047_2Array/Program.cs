// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5  7  -2  -0,2
// 1  -3,3  8  -9,9
// 8  7,8  -7,1  9

// 1.Метод ввода размера двумерного массива
int ReadInt(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}
// 2.Метод создания массива
double[,] CreateArray(int count1, int count2)
{
  return new double[count1,count2];
}
// 3.Метод заполнения двумерного массива случайными числами
void Fill(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
            }
    }
}

// 4.Метод печати массива
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j], 5}");
            }
        Console.WriteLine();
    }
}

Console.Clear();
int m = ReadInt("Введите количество строк и нажмите Enter: ");
int n = ReadInt("Введите количество столбцов и нажмите Enter: ");
double[,] arr = CreateArray(m,n);
Fill(arr);
PrintArray(arr);
