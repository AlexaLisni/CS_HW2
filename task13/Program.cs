// Задача 13: Напишите программу, которая выводит третью цифру заданного 
//числа или сообщает, что третьей цифры нет. Решить без использования строк.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("ведите  чило: ");
int num = Convert.ToInt32(Console.ReadLine());
int Unum = num;
if(num<100)
{
 Console.WriteLine("нет третей цифры ");
}

while(num>=1000)
{
    num = num / 10;
}

Console.WriteLine($"Третья цифра числа: {Unum}->{num % 10}");

