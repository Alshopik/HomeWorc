public static class MyLibrary1
{
// 0. Метод считывания числа от пользователя
public static int Input(string text)
  {
    Console.Write(text);
    return int.Parse(Console.ReadLine());
  }
// 1. Метод создания массива
public static int[] CreateArray(int count)
{
    return new int[count];
}
// 2. Метод который заполняет массива
public static void Fill(int[] array, int min, int max)
  {
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
      //array[i] = Random.Shared.Next(min, max);
      array[i] = new Random().Next(min, max);
    }
  }
// 3. Метод печати массива ПЛОХОЙ
public static void PrintBad(int[] array)
  {
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
      Console.WriteLine($"{array[i],3}");
    }
    Console.WriteLine();
  }
// 3. Метод печати массив !ПЛОХОЙ
  public static string PrintGood(int[] array)
  {
    string output = String.Empty;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
      output += $"{array[i],5}";
    }
    return output;
  }
// 4. Метод решения задачи найти количество элементов из отрезка [10,99]  [up,down]
public static int Counter(int[] array, int down, int up)
  {
    int result = 0;

    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
      if (array[i] >= down && array[i] <= up)
      {
        result++;
      }
    }

    return result;
  }


}