// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number/100>1)
{
    Console.WriteLine((number/100)%10);
}
else
{
    Console.WriteLine("Введенное число меньше 100 и у него нет третьей цифры");
}

