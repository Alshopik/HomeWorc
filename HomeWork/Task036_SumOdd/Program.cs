// 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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

// 5. Метод определения суммы элементов, стоящих на нечётных позициях
int SumOdd(int[] array)
{
  int result = 0;
    // int size = array.Length;
  for (int i = 1; i < array.Length; i += 2)
  {
    result += array[i];
  }
  return result;
}


Console.Clear();
int N = ReadInt("Введите количество элементов в масиве и нажмите Enter: "); // вводим количество элементов в массиве
int[] arr = CreateArray(N); // создаем массив из N элементов
Fill(arr, -99, 99); // заполням массив элементами от -+99 до 99 (двузначные)

Console.WriteLine(Print(arr)); // выводим массив на экран
Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях: {SumOdd(arr)}"); // выводим сумму элементов, стоящих на нечётных позициях