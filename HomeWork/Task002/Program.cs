// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

int number = 7;

Console.WriteLine(number);
Console.WriteLine("Является ли введенное число чeтным?");

if (number % 2 == 0)
{
    Console.WriteLine("ДА");
}
else 
{
    Console.WriteLine("НЕТ");
}