double AkkFunction (double first, double second)
{
if (first == 0) 
{
    return second + 1;
}
else 
{
    if (second == 0)
{
    return AkkFunction(first - 1, 1);
}
    else
    {
        return AkkFunction(first - 1, AkkFunction(first, second - 1));
    }
}
}

double m, n;

do
{
    Console.WriteLine ("Введите неотрицательные целые числа m и n");
    m = Convert.ToDouble (Console.ReadLine());
    n = Convert.ToDouble (Console.ReadLine());
} while (m < 0 || n < 0);

Console.WriteLine ("Значение функции Аккермана для чисел m и n = "+AkkFunction(m,n));
