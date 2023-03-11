void Numbers (int count)
{
    if (count == 1) Console.Write (count);
    else
    {
        Console.Write (count + ", ");
        Numbers (count - 1);
    }
}

int n;

do
{
    Console.WriteLine ("Задайте натуральное число N");
    n = Convert.ToInt32 (Console.ReadLine());
} while (n <= 0);

Console.WriteLine ("Натуральные числа в промежутке от N до 1:");
Numbers(n);
Console.WriteLine ();