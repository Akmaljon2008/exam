int a = Convert.ToInt32(Console.ReadLine());
int[] n = new int [a];
for (int i = 0; i < a; i++)
{
    n[i] = Convert.ToInt32(Console.ReadLine());
}
int min = 9999 , max=-999 , m = 0 , s = 0;
for (int i = 0; i < a; i++)
{
   if (n[i] < min){ 
   min = n[i];
   m = i;
   }
   if (n[i] > max){
    max = i;
    s = i;
   } 
}
for (int i = s; i < m; i++)
{
    Console.WriteLine(n[i]);
}