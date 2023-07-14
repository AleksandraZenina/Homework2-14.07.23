// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
Console.Write("Введите любое трёхзначное число: ");
int number = int.Parse (Console.ReadLine());
if (number>=100 && number<=999)
{
    number = number/10;
    Console.WriteLine(number%10);
}
else Console.WriteLine("Вы ввели неверное число");
