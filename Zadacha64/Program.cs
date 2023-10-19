void ShowNumbers(int n)
{
    if (n > 0)
    {
        Console.Write(n + " ");
        ShowNumbers(n - 1);
    }
}

ShowNumbers(8);