//По двум заданным числам проверять является ли первое квадратом второго

int a = 121;
int b = 10;

if (a == b * b)
{
    Console.Write("число ");
    Console.Write(a);
    Console.Write(" является квадратом числа ");
    Console.WriteLine(b);
}
else
{
    Console.Write("число ");
    Console.Write(a);
    Console.Write(" не является квадратом числа ");
    Console.Write(b);
}
