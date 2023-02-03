// Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


System.Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());


if(n > 100)
{
    System.Console.WriteLine($"{(n / 100) % 10}");
}
else
{
    System.Console.WriteLine("третьей цифры нет");
}


