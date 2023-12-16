void Swap(ref int a,ref int b)
{
    int c;
    c=a;
    a=b;
    b=c;
    Console.WriteLine(a + " " + b);
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Swap(ref a ,ref b);