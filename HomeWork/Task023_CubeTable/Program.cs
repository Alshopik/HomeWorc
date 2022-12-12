// 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Input(string text)
  {
    Console.Write(text);
    return int.Parse(Console.ReadLine());
  }

Console.Clear();

int number = Input("Введите число и нажмите Enter: ");

for (int i = 1; i <= number; i++)
{
Console.WriteLine($"{i}³ = {Math.Pow(i, 3)} ");
}