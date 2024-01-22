int n = Convert.ToInt32(Console.ReadLine());
int[] m = new int[n];
for (int i = 0; i < n; i++) 
{
    m[i] = Convert.ToInt32(Console.ReadLine());
}

int z = 0;
for (int i = 1; i < n; i++) 
{
  if (m[i] > m[i-1]) z++;
}
Console.WriteLine(z);
