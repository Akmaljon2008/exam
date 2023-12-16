int  Sum(int a)
{
    int sum = 0;
    for (int i = 0; i < a; i/=10)
    {
        sum += i % 10;
    }
    return sum;
}


int a = Convert.ToInt32(Console.ReadLine());
Console.Write($"The sum of digits of the number {a} is : ");
Console.WriteLine(Sum(a));