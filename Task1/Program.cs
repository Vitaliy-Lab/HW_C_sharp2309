// Напишите программу, 
// 1. которая принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа.
// 456->5 
// 782->8 
// 918->1

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    number *= -1;
}

if (number >= 100 && number <= 999)
{
    int intermediateNumber = number / 10;
    int secondNumber = intermediateNumber % 10;

    Console.WriteLine($"Вторая цифра этого числа -> {secondNumber}");
}
else
{
    Console.WriteLine("Eror");
}