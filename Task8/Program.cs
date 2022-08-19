Console.WriteLine("Введите целое положительное число ");
int x = Convert.ToInt32(Console.ReadLine());
for (int a = 1; a <= x; a++)
{
    if (a % 2 == 0)
    {
        Console.WriteLine(a);
    }
}