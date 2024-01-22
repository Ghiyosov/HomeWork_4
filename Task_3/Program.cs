int n = Convert.ToInt32(Console.ReadLine());
int[] m = new int[n];
for (int i = 0; i < n; i++) 
{
    m[i] = Convert.ToInt32(Console.ReadLine());
}

int Negative=0, Positive=0, Zeros=0, Even=0, Odd=0, Max=-1234567, Min=1234567, SumOfDig=0;       

for (int i = 0; i < n; i++) 
{
    if (m[i] < 0) Negative++;
    if (m[i] > 0)   Positive++;
    if (m[i] == 0) Zeros++;
    if (m[i]%2 == 0) Even++;
    if (m[i] != 0) Odd++;
    if (m[i] > Max) Max = m[i];
    if (m[i] < Min) Min = m[i];
    SumOfDig = SumOfDig + m[i];
}

Console.WriteLine("negative ==> "+Negative);
Console.WriteLine("positive ==> "+Positive);
Console.WriteLine("zeroes ==> "+Zeros);
Console.WriteLine("even ==>"+Even);
Console.WriteLine("odd ==> "+Odd);
Console.WriteLine("max ==> "+Max);
Console.WriteLine("min ==>"+Min);
Console.WriteLine("sum of digits"+SumOfDig);