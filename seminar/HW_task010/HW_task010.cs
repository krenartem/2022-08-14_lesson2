// принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 ^ number > 999)
{
    Console.WriteLine($"Число {number} не трехзначное");
}
else
{
    number = number / 10;
    Console.WriteLine($"Вторая цифра введенного числа {number % 10}");
}