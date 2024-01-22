string Grade(int a) 
{
    string b="r";
    if (a > 89 || a <= 100) b = "A";
    if (a > 79 || a <90) b = "B";
    if (a > 69 || a <80 ) b = "C";
    if (a > 59 || a <60) b = "D";
    if (a <60) b = "F";
    return b;
}

int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("You'r Grade ==> "+Grade(b));
