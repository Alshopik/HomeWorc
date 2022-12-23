// int[] arr = { 1, 2, 3, 4, 5, 6, 1, 2, 3, 22, 48, 4, 2, 6, 8, 7, 8, 2, 3 };

// Натуральные и ноль int+ -> 0-1000
// arr.Length => 10000

// 1 -> 2 шт.
// 2 -> 4 шт.
// 3 -> 3 шт.
// 4 -> 2 шт.
// 5 -> 1 шт.
// 6 -> 2 шт.
// 7 -> 1 шт.
// 8 -> 2 шт.
// 22 -> 1 шт.
// 48 -> 1 шт.

// 1. Считывание числа от пользователя

int ReadInt(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}
// 2. Создание массива

int[] CreateArray(int count)
{
  return new int[count];
}
// 3. Заполнить массив
// 3.1 случайно
// void Fill(int[] array, int min, int max)
// {
//   int size = array.Length;
//   for (int i = 0; i < size; i++)
//   {
//     array[i] = new Random().Next(min, max);
//   }
// }
// 3.2 с клавиатуры
void FillKey(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
}



// 4. Печать результата
string Print(int[] array)
{
  string output = String.Empty;
  int size = array.Length;
  for (int i = 0; i < size; i++)
  {
    output += $"{array[i],3}";
  }
  return output;
}
// 5. Составление "словаря"
int [,] Dictionary(int[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        int n = array[i];
        int quantity = 0;
        int name = 0;
        if (n == array[i])
        {
            quantity += 1;
        }
        int[,] dic = new int [2,1];
        dic [n,q] = new int [quantity,name];
    }
}


// 6
// 7
// 8


int N = ReadInt("Введите количество элементов в масиве и нажмите Enter: "); // вводим количество элементов в массиве
int[] arr = CreateArray(N); // создаем массив из N элементов
//Fill(arr, 0, 1000); // заполням массив элементами от 0 до 1000
FillKey(arr); // заполням массив c клавиатуры
Console.WriteLine(Print(arr)); // выводим массив на экран
int Dictionary(arr);
