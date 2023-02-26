// Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


Console.WriteLine("Введите Число N ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= N)
{
    Console.Write(Math.Pow(i,2) + "\t");  // Литеррал \t четере пробела \n пернос на  новую строчку
    i++;
}

//2 hрешение через for


Console.WriteLine("Введите Число N ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < length; i++)
{
    Console.Write(Math.Pow(i,2) + "\t");
}

// четные числа через цикл for

Console.WriteLine("Введите Число N ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < length; i = i +2)           //  i +=2
{
    Console.Write(+ "\t");

}