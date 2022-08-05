double FreeD(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = 0;
    double sum = Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2);
    float res = (float)sum;
    result = MathF.Sqrt(res);

    return result;
}

double ans = FreeD(3,6,8,2,1,-7);
Console.WriteLine($"{ans:f2}");

ans = FreeD(7,-5,0,1,-1,9);
Console.WriteLine($"{ans:f2}");