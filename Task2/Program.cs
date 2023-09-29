// Напишите программу
// 1. которая выводит третью цифру заданного числа или
// 2. сообщает, что третьей цифры нет.
// 645->5
// 78 -> третьей цифры нет 
// 32679 -> 6


Console.WriteLine("Введите число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());

while (anyNumber > 999)
{
  anyNumber = anyNumber / 10;
}
if (anyNumber >= 100 && anyNumber < 999)
{
  anyNumber = anyNumber % 10;
  Console.WriteLine($"третья цифра -> {anyNumber}");
}
else 
{
  Console.WriteLine("-> третьей цифры нет");
}