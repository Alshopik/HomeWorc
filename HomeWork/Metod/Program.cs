// Метод печати массива

void PrintArrya(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


// Метод упорядочивания массива
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) 
            {
            minPosition = j;
            }
        }
        int temrary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temrary;
    }
}


//Метод замены символа в тексте
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}


int[] arr = {1, 2, 4, 9, 7, 5, 4 , 6, 7, 8};

PrintArrya(arr);
SelectionSort(arr);
PrintArrya(arr);

string text = "Я к вам пишу — чего же боле?"
            + "Что я могу еще сказать?"
            + "Теперь, я знаю, в вашей воле"
            + "Меня презреньем наказать."
            + "Но вы, к моей несчастной доле"
            + "Хоть каплю жалости храня,"
            + "Вы не оставите меня.";

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);