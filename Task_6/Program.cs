int n = Convert.ToInt32(Console.ReadLine());
int[] m = new int[n];
for (int i = 0; i < n; i++) 
{
    m[i] = Convert.ToInt32(Console.ReadLine());

}

for (int i = 0; i < n; i++) 
{
    int z = 0;
    for (int j = 0; j < n; j++) 
    {
        if (m[i] == m[j] && i != j) z++; 
    }
    if (z > 0) Console.Write(m[i] + " ");

}