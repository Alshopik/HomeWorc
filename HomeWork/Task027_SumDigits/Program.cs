//27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12

int Input(string text)
  {
    Console.Write(text);
    return int.Parse(Console.ReadLine());
  }

  Console.Clear();

int number = Input("Введите число и нажмите Enter: ");
int Sum = 0;

for (int i = 1; i <= number; i++)
{
int B = number % 10;
Sum = Sum + B;
number = number/10;
}
Console.Write($"Сумма цифр введенного числа: {Sum}");