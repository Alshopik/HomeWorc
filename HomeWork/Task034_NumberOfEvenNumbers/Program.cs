// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


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

// 5. Метод определения количества четных чисел в массиве
int Even(int[] array)
{
    int result = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            result += 1;
        }
    }
    return result;
}


Console.Clear();
int N = ReadInt("Введите количество элементов в масиве и нажмите Enter: "); // вводим количество элементов в массиве
int[] arr = CreateArray(N); // создаем массив из N элементов
Fill(arr, 100, 999); // заполням массив элементами от 100 до 999 (положительные трехзначные)
// int[] arr = {345, 897, 568, 234}; // для ручной проверки
Console.WriteLine(Print(arr)); // выводим массив на экран
Console.WriteLine($"Количество четных чисел в масииве: {Even(arr)}"); // выводим количество четных чисел в массиве