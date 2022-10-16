Console.Clear();
Console.Write("Введите число от 1 до 7 :");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("Число соответствует понедельнику.");
}
if (number == 2)
{
    Console.WriteLine("Число соответствует вторнику.");
}
if (number == 3)
{
    Console.WriteLine("Число соответствует среде.");
}
if (number == 4)
{
    Console.WriteLine("Число соответствует четвергу.");
}
if (number == 5)
{
    Console.WriteLine("Число соответствует пятнице.");
}
if (number == 6)
{
    Console.WriteLine("Число соответствует субботе.");
}
if (number == 7)
{
    Console.WriteLine("Число соответствует воскресенью.");
}
