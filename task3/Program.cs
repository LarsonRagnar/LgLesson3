// Напишите программу, которая принимает 
// на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// корень ((x-x1)^2 + (y-y1)^2)


Console.WriteLine("Введите координату по оси X 1 точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату по оси Y 1 точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату по оси X 2 точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату по оси Y 2 точки");
int y2 = Convert.ToInt32(Console.ReadLine());
//Math.Sqrt математический метод корень
//Math.Pow математический метод степень, второе значение в какую степень возводить
//Math.Round математический метод округление до целого числа, второе зачение количество знаков после запятой
//Console.WriteLine($"Растояние между точками равно {result:f3}");    // :f3 в выводе будет три символа                                                                      
var result = Math.Sqrt(Math.Pow(x2 - x1, 2 ) + Math.Pow(y2 - y1, 2 ));
Console.WriteLine($"Растояние между точками равно {Math.Round (result, 3)}");


