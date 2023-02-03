// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот 
// день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.WriteLine("Введите номер дня недели :"); 
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 &&  day < 6)
{
    System.Console.WriteLine($"Рабочий день");
}
else if(day > 5 && day <8)
{
    System.Console.WriteLine($"Выходной день");
}
else
{
    System.Console.WriteLine($"Дня недели не существует");
}
