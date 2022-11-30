int Max(int n1, int n2, int n3)
{
    int max = n1;
    if (n2 > max) max = n2;
    if (n3 > max) max = n3;
    return max;
}
int a1 = 15;
int b1 = 1221;
int c1 = 391;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 143;
int b3 = 28;
int c3 = 31;
// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int result = Max(max1, max2, max3);
int result = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));
Console.WriteLine(result);