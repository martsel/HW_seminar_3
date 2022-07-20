//задача 17

int [] point = new int[2];

Console.WriteLine("Введите координиату по X");
point[0]=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координиату по Y");
point[1]=Convert.ToInt32(Console.ReadLine());

if (point[0] > 0 && point[1] > 0)
{
    Console.WriteLine("Точка находится в 1 четверти");
}
if (point[0] < 0 && point[1] > 0)
{
    Console.WriteLine("Точка находится во 2 четверти");
}
if (point[0] < 0 && point[1] < 0)
{
    Console.WriteLine("Точка находится в 3 четверти");
}
if (point[0] > 0 && point[1] < 0)
{
    Console.WriteLine("Точка находится в 4 четверти");
}
