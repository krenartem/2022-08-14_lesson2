// убрать вторую цифру из случайного трехзначного числа, вывести получившее двузначное число на экран
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
Console.WriteLine($"удаляем вторую цифру, остается {number / 100}{number % 10}");