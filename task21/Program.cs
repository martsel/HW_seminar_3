// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите первую координиату по A");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первую координиату по B");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую координиату по A");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координиату по B");
int b2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(a2-a1, 2) + Math.Pow(b1-b2, 2));
Console.WriteLine(result);

