// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4


// 1. Метод ввода количество чисел М
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

// 3. Метод ввода чисел (заполнение массива)
void FillKey(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
}

// 4. Метод определения количество чисел больше 0

int Numbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count +=1;
    }
    return count;
}

Console.Clear();
int M = ReadInt("Введите количество чисел и нажмите Enter: "); // вводим количество элементов в массиве
int[] arr = CreateArray(M); // создаем массив из M элементов
Console.WriteLine("Введите числа");
FillKey(arr); // заполням массив c клавиатуры
Console.WriteLine($"Количество введенных чисел больше 0: {Numbers(arr)}");