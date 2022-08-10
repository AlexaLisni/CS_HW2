// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("ведите трехзначное чило: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num>99 & num<1000)
{
    Console.WriteLine($"Случайное число 100 до 999 => {num}");
    Console.WriteLine($" Вторая цифра числа {num}->{(num /10)%10} ");
}
else {
    Console.WriteLine("ведите ТРЕХЗНАЧНОЕ (пример: '123') чило: ");
}
//int num = new Random().Next(100, 1000);




