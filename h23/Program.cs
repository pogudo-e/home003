void Kub(int num)
{
    for(int i = 1; i <= num; i++)
    {
        Console.Write($"{i*i*i} ");
    }
    Console.WriteLine();
}

Kub(3);
Kub(5);