// Ввести 2 числа, проверить, делится ли первое на второе без остатка
Console.Clear();
Console.WriteLine("Введите делимое: ");
int divisible = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите делитель: ");
int divider = Convert.ToInt32(Console.ReadLine());
if (divisible % divider == 0)
{
    Console.WriteLine($"{divisible} делится на {divider} без остатка");
}
else
{
    Console.WriteLine($"остаток от деления {divisible} на {divider} = {divisible % divider}");
}