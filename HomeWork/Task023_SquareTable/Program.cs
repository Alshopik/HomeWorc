// 23. Показать таблицу квадратов чисел от 1 до N 

int Input(string text)
  {
    Console.Write(text);
    return int.Parse(Console.ReadLine());
  }

Console.Clear();

int number = Input("Введите число и нажмите Enter: ");

for (int i = 1; i <= number; i++)
{
Console.Write($"{Math.Pow(i, 2)} ");
}