int numberA = new Random().Next(1, 26);
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 6);
Console.WriteLine(numberB);
int square = numberB * numberB;
if (square == numberA)
{
    Console.WriteLine("Совпало!");
}
else
{
    Console.WriteLine("Не получилось. Попробуй заново.");
}