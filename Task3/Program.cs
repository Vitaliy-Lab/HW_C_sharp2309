// Напишите программу
// 1. которая принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.
// 6->да 
// 7->да 
// 1->нет

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber == 6 || dayNumber == 7) 
{
    Console.WriteLine("(этот день выходной) -> да");
}
else if (dayNumber < 1 || dayNumber > 7) 
{
    Console.WriteLine("это вообще не день недели");
}
else 
{
    Console.WriteLine("(этот день не выходной) -> нет");
}