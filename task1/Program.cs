// Вводится строчка, надо проверить все ли символы являются числами
// 1234 подходит
//  1234привет не подходит

var stringNumber = "1234";

int number; // 

bool isNumber = int.TryParse(stringNumber, out number);  // Метод проверки является ли символы числами

Console.WriteLine(isNumber);  // TryParse проебразование строчки в формат числа
Console.WriteLine(number);




