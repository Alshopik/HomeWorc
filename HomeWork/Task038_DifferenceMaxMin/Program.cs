// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


// 1.Метод2 ввода числа
int ReadInt(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

// 2. Метод создания массива
int[] CreateArray(int count)
{
  return new int[count];
}

// 3. Метод который заполняет массива
void Fill(int[] array, int min, int max)
  {
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
      array[i] = new Random().Next(min, max);
    }
  }
  
// 4. Метод вывода массива на экран
string Print(int[] array)
  {
    string output = String.Empty;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
      output += $"{array[i],5}";
    }
    return output;
  }

// // 5. Метод определения максимального элемента в массиве
// int Max(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         int maximum = array[i];
//         if (array[i] > maximum)
//         {
//             maximum = array[i];
//         }
//     }
//     return maximum;
// }

// // 5. Метод определения минимального элемента в массиве
// int Min(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         int minimum = array[i];
//         if (array[i] < minimum)
//         {
//             minimum = array[i];
//         }
//     }
//     return minimum;
// }


int N = ReadInt("Введите количество элементов в масиве и нажмите Enter: "); // вводим количество элементов в массиве
int[] arr = CreateArray(N); // создаем массив из N элементов
Fill(arr, 0, 100); // заполням массив элементами

Console.WriteLine(Print(arr)); // выводим массив на экран
// Console.WriteLine($"Pазницa между максимальным и минимальным элементом массива: {Max(arr)} - {Min(arr)} = {Max(arr)-Min(arr)}"); // выводим разницу

for (int i = 0; i < arr.Length; i++)
{
int m = arr[i];
if (arr[i] > m)
{
m = arr[i];
}
}
Console.WriteLine($"{m}");
