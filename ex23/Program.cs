Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

for (int x = 0; x <= n; x++) 
{
    Console.WriteLine(Math.Pow(x, 3));
}