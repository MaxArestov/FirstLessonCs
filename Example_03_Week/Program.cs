Console.Clear();
Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case 1:
    Console.WriteLine("Число соответствует понедельнику");
    break;
    case 2:
    Console.WriteLine("Число соответствует вторнику");
    break;
    case 3:
    Console.WriteLine("Число соответствует среде");
    break;
    case 4:
    Console.WriteLine("Число соответствует четвергу");
    break;
    case 5:
    Console.WriteLine("Число соответствует пятнице");
    break;
    case 6:
    Console.WriteLine("Число соответствует субботе");
    break;
    case 7:
    Console.WriteLine("Число соответствует воскресенью");
    break;
}
