// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()??"0");
if (n<1)
{
    Console.WriteLine("Введите число от 1");
}
else
{
for (int x = 1; x <=Math.Abs(n); x++)
{
    Console.WriteLine(Math.Pow(x, 3));
}
}