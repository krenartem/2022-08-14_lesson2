// выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите число: ");
string numberString = Console.ReadLine();
int length = numberString.Length;
if (length < 3)
{
    Console.WriteLine($"В числе {numberString} третьей цифры нет");
}
else
{
    int number = Convert.ToInt32(numberString);
    while (length > 3)
    {
        number = number / 10;
        length = length - 1;
    }
    number = number % 10;
    Console.WriteLine($"В числе {numberString} третья цифра {number}");
}