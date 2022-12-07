//Методы
void PrintArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SortArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < length; j++)
        {
            if (array[maxPosition] < array[j]) maxPosition = j;
        }
        int temp = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temp;
    }    
}
//Дано
int[] array = { 2, 5, 1, 7, 3, 2, 7, 8, 3, 9, 4, 6 };
//Выполнение
PrintArray(array);
SortArray(array);
PrintArray(array);
