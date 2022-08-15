// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

for (int x = 1; x <=Math.Abs(n); x++)
{
    Console.WriteLine(Math.Pow(x, 3));
}