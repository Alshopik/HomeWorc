// Дано число. Проверить кратно ли оно 7 и 23

Console.Clear();
int number = 805;

Console.WriteLine(number);
Console.WriteLine("Является ли введенное число кратно  7 и 23?");

if (number % 7 == 0)
{
    Console.WriteLine("Число кратно 7");
}
else 
{
    Console.WriteLine("Число не кратно 7");
}
if (number % 23 == 0)
{
    Console.WriteLine("Число кратно 23");
}
else 
{
    Console.WriteLine("Число не кратно 23");
}