int SumNumbers (int first, int last)
{
    if (first == last) return first;
    else
    {
        if (last > first)
        {
            return last + SumNumbers (first, last-1);
        }
        else
        {
            return first + SumNumbers (first-1, last);
        }
    }
}

int m, n;

do
{
    Console.WriteLine ("Задайте натуральные числа M и N");
    m = Convert.ToInt32 (Console.ReadLine());
    n = Convert.ToInt32 (Console.ReadLine());
} while (m <=0 || n <= 0);

Console.WriteLine ("Сумма натуральных элементов в промежутке от M до N включительно = "+SumNumbers(m,n));
