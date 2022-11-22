/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. */

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= num)
{
    Console.WriteLine(Math.Pow(count, 3));
    
    count++;
}
