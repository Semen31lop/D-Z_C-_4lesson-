//  у меня опять не выходит (((((
//Console.Write("Введите число: ");
//int num = int.Parse(Console.ReadLine()!);
//SumNumbers(count);

//void SumNumbers(int number);
//int count = 0;
//while (number > 0) ;
//{
//    int remains = number % 10;
 //   number = number / 10;
 //   count = count + remains;

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int count = 0;
while (num > 0) 
{
    int remains = num % 10;
    num = num / 10;
    count = count + remains;
}
Console.WriteLine($"{num}-->{count}");