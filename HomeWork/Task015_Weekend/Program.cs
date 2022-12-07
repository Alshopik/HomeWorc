// 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6, 7 - выходной.
//НО дня с индексом 0 или 12 не существует.
//6 -> да
// 7 -> да
// 1 -> нет


int Input(string text)
  {
    Console.Write(text);
    return int.Parse(Console.ReadLine());
  }
  
  Console.Clear();
  int day = Input("Введите день недели и нажмите Enter: ");

if (day < 1 || day > 7)
{
    Console.WriteLine($"ДНЯ С ИНДЕКСОМ {day} НЕ СУЩЕСТВУЕТ");
}
// if (day == 1)
// {
//     Console.WriteLine("ПОНЕДЕЛЬНИК");
// }
// if (day == 2)
// {
//     Console.WriteLine("ВТОРНИК");
// }
// if (day == 3)
// {
//     Console.WriteLine("СРЕДА");
// }
// if (day == 4)
// {
//     Console.WriteLine("ЧЕТВЕРГ");
// }
// if (day == 5)
// {
//     Console.WriteLine("ПЯТНИЦА");
// }
// if (day == 6)
// {
//     Console.WriteLine("СУББОТА");
// }
// if (day == 7)
// {
//     Console.WriteLine("ВОСКРЕСЕНЬЕ");
// }
if (day > 1 && day < 7)
{
    Console.WriteLine("РАБОЧИЙ ДЕНЬ");    //НЕТ - РАБОЧИЙ ДЕНЬ
}
if (day == 6 || day == 7)
{
    Console.WriteLine("ВЫХОДНОЙ");        //ДА - ВЫХОДНОЙ
}