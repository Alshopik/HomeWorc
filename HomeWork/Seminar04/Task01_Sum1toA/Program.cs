//Напишите программу, которая принимает на вход число А и выдает сумму чисел от 1 до А


// 1.Метод2 ввода числа
int ReadInt(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

// 2. Метод суммирования чисел от 1 до А
int Sum(int A)
{
    int Sum = 0;
    for (int i = 0; i <= A; i++)
    {
        Sum += i;
    }
    return Sum;
}

Console.Clear();
int A = ReadInt("Введите число и нажмите Enter: ");
Console.WriteLine($"{Sum(A)}");