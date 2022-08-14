// Ввести число и проверить делится ли оно на 7 и на 23 без остатка
Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 & number % 23 == 0)
{
    Console.WriteLine($"УРА {number} делится на 7 и 23 без остатка");
}
else
{
    Console.WriteLine($"{number} не делится на 7 и 23 без остатка");
}