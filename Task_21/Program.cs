/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве. */

double dist = 0;

Console.Write("Введите координаты X первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты X второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты Y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты Y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты Z первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты Z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine("Расстояние между двумя точками в пространстве равно " + Math.Round(dist, 2));

