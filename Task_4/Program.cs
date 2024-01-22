int n = Convert.ToInt32(Console.ReadLine());
int[] m = new int[n];
for (int i = 0; i < n; i++) 
{
    m[i] = Convert.ToInt32(Console.ReadLine());
}


for (int i = 0; i < n; i++) 
{
  if (i%2 == 0) Console.Write(m[i] +" ");
}

