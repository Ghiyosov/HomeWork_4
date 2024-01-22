int x= Convert.ToInt32(Console.ReadLine());
int y= Convert.ToInt32(Console.ReadLine());

for (int i = x; i <= y; i++) 
{
    Console.WriteLine("............................");
    for (int j = 0; j <= 10; j++) 
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
}