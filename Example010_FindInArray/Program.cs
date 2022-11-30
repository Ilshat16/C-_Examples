int[] array = { 12, 32, 113, 62, 72, 17, 32, 22, 91, 44 };
int find = 32;
int n = array.Length;
int index = 0;
while (index < n)
{
    if (array[index] == find) 
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
