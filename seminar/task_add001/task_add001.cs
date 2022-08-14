// Найти наибольшую из цифр случайного двузначного числа
int number = new Random().Next(10, 100);
Console.WriteLine(number);
// int num1 = number / 10;
Console.WriteLine($"Первая цифра {number / 10}");
// int num2 = number % 10;
Console.WriteLine($"Вторая цифра {number % 10}");
if (number / 10 > number % 10)
{
    Console.WriteLine($"Наибольшая цифра {number / 10}");
}
else
{
    Console.WriteLine($"Наибольшая цифра {number % 10}");
}