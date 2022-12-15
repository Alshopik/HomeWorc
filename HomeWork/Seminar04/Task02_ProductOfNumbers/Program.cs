//Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N


// 1.Метод2 ввода числа
int ReadInt(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

// 2. Метод суммирования чисел от 1 до N
int Pro(int N)
{
    int Pro = 1;
    for (int i = 1; i <= N; i++)
    {
        Pro *= i;
    }
    return Pro;
}

Console.Clear();
int N = ReadInt("Введите число и нажмите Enter: ");
Console.WriteLine($"Произведение чисел от 1 до {N}: {Pro(N)}");