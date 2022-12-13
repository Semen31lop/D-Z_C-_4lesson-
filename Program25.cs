//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine()!);
int result = 1;
for (int i = 1; i <= b; i++)
{
    result = result * a;
} 
Console.WriteLine($"{a} в степени {b}={result}");
// ** Задание вроде сделано , но вот через метод у меня не вышло. Оно выдавало ошибку в данном случае в 20 строке , я вот не понимаю почему **
//Console.Write("Введите число A: ");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write("Введите число B: ");
//int num2 = int.Parse(Console.ReadLine());
//Console.Write("Введите число A: ");
////Console.WriteLine($"{num1} в степени {num2}={ToDegree{result}}");

// int ToDegree(int a ; int b );
//int result = 1;
//for (int i = 1; i <= b; i++)
//{
//    result = result * a;
//} 
//return result
