// Напишите программу, которая выводит массив из 8 элементов, заполняет нулями и единицами
// показать десятичное представление получившегося двоичного числа


// 1. Метод создания массива из 8 элементов
int[] CreateArray(int count)
{
    return new int[count];
}
// 2. Метод который заполняет массива 0 и 1
void Fill(int[] array)
  {
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
  }
// 3. Метод вывода массива на экран
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

// 4. Метод возведения числа a в степень b
int Pow(int a, int b)
{
int result = 1;
for (int i = 0; i < b; i++)
{
result *= a;  //result = result * a;
}
return result;
}

// Конвертор из 2-ой в 10-ую
//  0  1  2  3  4  5  6  7
// [1, 0, 0, 1, 0, 1, 0, 1]
//  7  6  5  4  3  2  1  0
//  1*2^7 + 0*2^6 + 0*2^5 + 1*2^4 + 0*2^3 + 1*2^2 + 0*2^1 + 1*2^0

int ToDec(int[] value)
{
  int result = 0;
  int count = value.Length;

  for (int i = 0; i < count; i++)
  {
    result += value[i] * Pow(2, count-1-i);
  }
  return result;
}



Console.Clear();
int[] arr = CreateArray(8); // создаем массив из 8 элементов
Fill(arr); // заполням массив
Console.WriteLine(Print(arr)); // выводим массив на экран
Console.WriteLine(ToDec(arr));