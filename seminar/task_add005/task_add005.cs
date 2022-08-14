// ввести 2 числа и проверить, является ли любое из них квадратом другого
Console.Clear();
Console.Write("Введите число А: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число Б: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2*number2 ^ number2 == number1*number1)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}