//21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//A (0,0); B (1,1), -> ~1.414...
//A (2,4); B (0,7) -> ~3.605...


double xA = 2;
double yA = 4;
double xB = 0;
double yB = 7;

double d = Math.Sqrt(Math.Pow((xA - xB), 2) + Math.Pow((yA - yB), 2));
Console.WriteLine(d);