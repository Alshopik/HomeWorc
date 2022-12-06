//5. Написать программу вычисления значения функции y = sin(a)

int a = 90;       //в градусах        
double result = Math.Sin(a*Math.PI/180);     //число Пи - Math.PI; перевод градусов в радианы  a*Math.PI/180
Console.WriteLine(result);