int NumbersAmount(int M, int N)
{
    int sum = 0;
    while (M <= N)
    {
        sum += M;
        M++;
    }
    return sum;
}

Console.WriteLine(NumbersAmount(4, 8));