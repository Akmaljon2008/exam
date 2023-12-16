int a = Convert.ToInt32(Console.ReadLine());
int [] n = new int [a];
for (int i = 0; i < a; i++)
{
    n[i] = Convert.ToInt32(Console.ReadLine());
}
int cnt = 0;
int b = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <a; i++)
{
    if (n[i] == b)cnt++;
}
Console.WriteLine();
Console.WriteLine(cnt);