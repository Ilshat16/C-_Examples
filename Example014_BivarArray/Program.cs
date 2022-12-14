//Методы
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1, 10);
        }
    }
}
//Создать двумерный массив
int[,] matrix = new int[5, 8];
//Распечатать массив
PrintArray(matrix);
Console.WriteLine();
//Заполнение массива
FillArray(matrix);
//Распечатать заполненный массив
PrintArray(matrix);