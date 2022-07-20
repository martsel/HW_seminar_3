// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// string str = length[];
// Console.WriteLine(str[1]);
// int [] number=new int [4];
// Console.WriteLine(number[2]);

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number [5]!= null || number [4] == null)
// {
//     Console.WriteLine("Введите пятизначное число");
// } 

Console.WriteLine("Введите число: ");
var n = new int[4];
if (n [5]!= null || n [4] == null)
{
    Console.WriteLine("Введите пятизначное число");
} 
if(n[0]==n[4] && n[1]==n[3])
{
    Console.WriteLine("Yes");
}
Console.WriteLine("No");