// 29: Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) и выводит на экран десятичное представление числа, записанного в СС по основанию 15
// N: 3 [9, 4, 12] => 2097


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
      output += $"{array[i],3}";
    }
    return output;
  }

// 5. Метод возведения числа a в степень b
int Pow(int a, int b)
{
int result = 1;
for (int i = 0; i < b; i++)
{
result *= a;  //result = result * a;
}
return result;
}
// Конвертор из 15-ой в 10-ую
//  0  1  2   3
// [6, 4, 3, 11]
//  3  2  1   0
//  11*15^0 + 3*15^1 + 4*15^2 + 6*15^3

int ToDec(int[] value)
{
  int result = 0;
  int count = value.Length;

  for (int i = 0; i < count; i++)
  {
    result += value[i] * Pow(15, count-1-i);
  }
  return result;
}



int N = ReadInt("Введите количество элементов в масиве и нажмите Enter: "); // вводим количество элементов в массиве
int[] arr = CreateArray(N); // создаем массив из N элементов
Fill(arr, 0, 14); // заполням массив элементами от 0 до 14
Console.WriteLine(Print(arr)); // выводим массив на экран
Console.WriteLine(ToDec(arr)); // выводим десятичное представление числа, записанного в СС по основанию 15
