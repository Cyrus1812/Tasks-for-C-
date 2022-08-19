Console.WriteLine("Впишите 2 числа ");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = 0;

if (max < b)
{
    max = b;
    min = a;
    Console.Write("max = ");
    Console.WriteLine(b);
    Console.Write("min = ");
    Console.Write(a);
}
if (max > b)
{
    min = b;
    Console.Write("max = ");
    Console.WriteLine(a);
    Console.Write("min = ");
    Console.Write(b);
}