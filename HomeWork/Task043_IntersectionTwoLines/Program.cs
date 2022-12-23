// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//x=(b2-b1)/(k1-k2)
//y=k1(b2-b1)/(k1-k2)+b1
//y=k1*x+b1

// 1. Метод создания массива
double[] CreateArray(int count)
{
  return new double[count];
}

// 2. Метод ввода чисел (заполнение массива)
void FillKey(double[] array, string text)
{
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите коэффициент {text}{i+1} и нажмите Enter:");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
}

//3. Метод определения точки пересечения
void CrossPoint (double[] array1, double[] array2)
{
    double CrossPointX = (array1[1]-array1[0])/(array2[0]-array2[1]);
    double CrossPointY = array2[0]*CrossPointX+array1[0];
    Console.WriteLine($"Точка пересечния: ({CrossPointX}; {CrossPointY})");
}


double [] arrB= CreateArray(2);
FillKey(arrB, "b"); 
double [] arrK= CreateArray(2);
FillKey(arrK, "k");
CrossPoint(arrB, arrK);