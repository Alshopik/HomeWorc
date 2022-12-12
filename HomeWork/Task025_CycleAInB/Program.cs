// 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16

// Метод ввода числа
int Input(string text)
  {
    Console.Write(text);
    return int.Parse(Console.ReadLine());
  }

// Метод возведения числа a в степень b
int Pow(int a, int b)
{
int result = 1;
for (int i = 0; i < b; i++)
{
result *= a;  //result = result * a;
}
return result;
}


Console.Clear();

int a = Input("Введите число А и нажмите Enter: ");
int b = Input("Введите число B и нажмите Enter: ");

Console.Write($"{Pow(a, b)}");