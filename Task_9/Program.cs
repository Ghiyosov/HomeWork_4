  int c=1;
int z = 0;

int daraja(int a, int b) 
{
  
    c *= a;
    z++;
    if (z == b)
        return c;
    else return daraja(a, b );
}
Console.WriteLine(daraja(6,3));