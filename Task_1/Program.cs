int z = 0;

int Even(int a) 
{

    if ((a % 10) % 2 == 0) z++;

    if (a < 10)
        return z;

    else return Even(a/10);
}
Console.WriteLine("Even ==> "+Even(1234));



z = 0;

int Odd(int a)
{

    if ((a % 10) % 2 != 0) z++;

    if (a < 10)
        return z;

    else return Odd(a / 10);
}
Console.WriteLine("Odd ==> " + Odd(1234));

z = 0;

int Zeroes(int a)
{

    if ((a % 10)  == 0) z++;

    if (a < 10)
        return z;

    else return Zeroes(a / 10);
}
Console.WriteLine("Zeroes ==> " + Zeroes(123004));

z = 0;

int Digits(int a)
{

    z++;

    if (a < 10)
        return z;

    else return Digits(a / 10);
}
Console.WriteLine("Digits ==> " + Digits(1234));


z = 1234567;

int Min(int a)
{

    if (a % 10 < z) z=a%10;

    if (a < 10)
        return z;

    else return Min(a / 10);
}
Console.WriteLine("Min ==> " + Min(1234));


z = -1234567;

int Max(int a)
{

    if (a % 10 > z) z = a % 10;

    if (a < 10)
        return z;

    else return Max(a / 10);
}
Console.WriteLine("Max ==> " + Max(1234));

z = 0;
int SumDig(int a)
{

    z =z + a % 10;

    if (a < 10)
        return z;

    else return SumDig(a / 10);
}
Console.WriteLine("SumOfDig ==> " + SumDig(1234));