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

void FillImage(int[,] matr, int row, int col)
{
    if (matr[row, col] == 0)
    {
        matr[row, col] = 1;
        FillImage(matr, row-1, col);
        FillImage(matr, row, col-1);
        FillImage(matr, row+1, col);
        FillImage(matr, row, col+1);
    }
}

void DrawRhombus(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0) / 2; i++)
    {
        matr[i, (matr.GetLength(1) / 2) - i] = 1;
        matr[i, (matr.GetLength(1) / 2) + i] = 1;
    }
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[matr.GetLength(0) / 2, j] = 1;
    }
    // for (int i = matr.GetLength(0) /2; i < matr.GetLength(0); i++)
    // {
    //     matr[i, matr.GetLength(1)/2 + i] = 1;
    //     matr[i, matr.GetLength(1)/2 - i] = 1;
    // }
}
//Создать двумерный массив
int[,] matrix = new int[17, 17];
//Создать картинку ромба
DrawRhombus(matrix);
//Распечатать массив
PrintArray(matrix);
// Console.WriteLine();
//Заполнение массива
FillImage(matrix, 7, 8);
// //Распечатать заполненный массив
PrintArray(matrix);