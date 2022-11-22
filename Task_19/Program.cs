/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.*/

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

string pal = Convert.ToString(number);

if (pal.Length == 5)
{
    if (pal[0] == pal[4] && pal[1] == pal[3])
    {
        Console.WriteLine($"{pal} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{pal} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"{pal} - Введенное Вами число не является пятизначным");
}


