// 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Input(string text)
  {
    Console.Write(text);
    return int.Parse(Console.ReadLine());
  }
  
  Console.Clear();
  int a = Input("Введите число и нажмите Enter: ");

if (a > 99)
{
    int b = (int)Math.Floor(Math.Log10(a)) - 2;
    int d = (int)Math.Pow(10, b);
    Console.WriteLine("Третья цифра числа " + a / d % 10);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}