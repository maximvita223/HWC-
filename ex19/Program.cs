// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Введите пятизначное число");
int num = int.Parse(Console.ReadLine()??"0");
int res = 0;
int num1 = num;
while (num1 > 0)
{
    {
        res = res * 10 + num1 % 10;
        num1 /= 10;
    }
}
if (num == res)
{
    Console.WriteLine($"Число {num} палиондром");
}
else
{
    Console.WriteLine($"Число {num} не палиондром");
}

