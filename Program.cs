// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру 
// этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);

// int result = num/10 %10;
// Console.WriteLine(result);

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int num = new Random().Next(10, 40000);
Console.WriteLine(num);

int result1 = num%10;    
int result2 = num/10 %10;
int result3 = num/100 %10;

if((num>99) && (num<1000))
{
    Console.WriteLine(result1);
}
else if((num>999) && (num<10000))
{
    Console.WriteLine(result2);
}
else if(num>9999)
{
    Console.WriteLine(result3);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// int num = new Random().Next(0, 10);
// Console.WriteLine(num);

// if((num>5) && (num<=7))
// {
//     Console.WriteLine("Да");
// }
// else 
// {
//    Console.WriteLine("Нет"); 
// }