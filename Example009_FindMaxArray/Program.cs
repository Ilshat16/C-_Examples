int Max(int n1, int n2, int n3)
{
    int max = n1;
    if (n2 > max) max = n2;
    if (n3 > max) max = n3;
    return max;
}
 //Индексы        0   1   2   3   4   5   6   7
int[] array = { 12, 32, 113, 62, 72, 17, 22, 91, 44 };

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));
Console.WriteLine(result);