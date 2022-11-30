Console.Clear();
int ax = 1;
int ay = 1;
Console.SetCursorPosition(ax, ay);
Console.WriteLine("+");
int bx = 1;
int by = 30;
Console.SetCursorPosition(bx, by);
Console.WriteLine("+");
int cx = 80;
int cy = 30;
Console.SetCursorPosition(cx, cy);
Console.WriteLine("+");
int nx = ax;
int ny = by;
int count = 0;
while (count < 10000)
{
    int num = new Random().Next(0, 3);
    if (num == 0)
    {
        nx = (nx + ax) / 2;
        ny = (ny + ay) / 2;
    }
    if (num == 1)
    {
        nx = (nx + bx) / 2;
        ny = (ny + by) / 2;
    }
    if (num == 2)
    {
        nx = (nx + cx) / 2;
        ny = (ny + cy) / 2;
    }
    Console.SetCursorPosition(nx, ny);
    Console.WriteLine("+");
    count++;
}