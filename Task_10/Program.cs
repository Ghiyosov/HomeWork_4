int f1 = 1;
int f0 = 0;
int f2 = 0;
int z = 0;

void Fibo(int n) 
{
    Console.Write(f2 + " ");
    f2 = f1 + f0;
    f0 = f1;
    f1 = f2;
    z++;
    if (n == z)
        return;
    
   Fibo(n);
}

Fibo(6);