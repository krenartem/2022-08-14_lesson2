// принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введите номер дня недели, от 1 до 7: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber < 1 ^ dayNumber > 7)
{
    Console.WriteLine("Введенный номер вне диапазона от 1 до 7");
}
else
{
    if (dayNumber == 6 ^ dayNumber == 7)
    {
        Console.WriteLine($"УРА день {dayNumber} - ВЫХОДНОЙ!");
    }
    else
    {
        Console.WriteLine($"День недели {dayNumber} не является выходным");
    }
}