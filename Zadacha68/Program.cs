int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
       return n + 1;
    }
    else if (n == 0)
        {
            return AkkermanFunction(m - 1, 1);
        }
        else
        {
            return AkkermanFunction(m - 1, AkkermanFunction(m, n -1));
        }
}

Console.WriteLine(AkkermanFunction(3, 2));