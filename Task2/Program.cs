int a = Convert.ToInt32(Console.ReadLine());
int[] n = new int [a];

for (int i = 0; i < a; i++)
{
    n[i] = Convert.ToInt32(Console.ReadLine());
}
int k = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
for (int i = 0; i < a; i++)
{
    Console.Write(n[i] + " ");
    if (i == k) continue;
}