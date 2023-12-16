int a = Convert.ToInt32(Console.ReadLine());
int [] n = new int [a];
for (int i = 0; i < a; i++)
{
    n[i] = Convert.ToInt32(Console.ReadLine());
}
int cnt = 0;
for (int i = 0; i < a; i++)
{
    if (n[i] != n[i+1])cnt++;

}
System.Console.WriteLine(cnt);