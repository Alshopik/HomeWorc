// 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Input(string text)
  {
    Console.Write(text);
    return int.Parse(Console.ReadLine());
  }

  Console.Clear();

int A = Input("Введите число А и нажмите Enter: ");
int B = Input("Введите число B и нажмите Enter: ");
int degree = A;
for (int i = 2; i <= B; i++)
{
degree = degree * A;
}
Console.Write($"{degree}");