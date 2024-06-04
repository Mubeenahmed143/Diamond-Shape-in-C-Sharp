// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Making a Diamond Shape");

for(int a=1;  a<=5;  a++)
{
    for(int b=5-a;  b>0;  b--)
    {
        Console.Write(" ");
    }
        for(int c=1; c<=a; c++)
        {
            Console.Write("* ");
        }
    Console.WriteLine();
}
for(int i=5-1; i>=1; i--)
{
    for (int j = 5 - i; j > 0; j--)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= i; k++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}

