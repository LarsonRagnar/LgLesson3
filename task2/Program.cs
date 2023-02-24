// Напишите программу, которая принимает 
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта точка.


Console.WriteLine("Введите кординату по оси X");
int x = Convert.ToInt32(Console.WriteLine());
Console.WriteLine("Введите кординату по оси Y");
int y = Convert.ToInt32(Console.WriteLine());
if (x > 0 && y > 0)
{
    Console.WriteLine("Мы попали в первую четверть");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Мы попали в 2 четверть");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Мы попали в 3 четверть");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Мы попали в 4 четверть");
}
else
{
    Console.WriteLine("попадание в ось");

}