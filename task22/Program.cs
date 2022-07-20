// Задача 22: Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());
int[] squares = new int[number];
Console.Write("Таблица квадратов: ");
int i = 0;

while(i<number)
{
    squares[i] = (i+1)*(i+1);
    Console.Write($"{squares[i]} ");
    i++;
}

// Console.WriteLine("Введите число:  ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write("Таблица квадратов: ");
// for(int i = 1; i <= number; i++)
// {
//     Console.Write($"{i*i} ");
// }
