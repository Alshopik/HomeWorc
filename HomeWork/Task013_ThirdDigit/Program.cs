

int a = 245;

int b = (int)Math.Floor(Math.Log10(a)) - 2;
int d = (int)Math.Pow(10, b);
Console.WriteLine(a / d % 10);