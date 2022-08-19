Console.WriteLine("Впишите 2 числа ");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int max = a;

if (max < b)
{
    max = b;
    Console.WriteLine(b);
}
if (max > b)
{
    Console.WriteLine(a);
}