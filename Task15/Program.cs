// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine());
if (number<=7)
{
    if (number==6 || number==7) Console.WriteLine ("Это выходной!");
    else Console.WriteLine("Работаем дальше!");
    
} 
else Console.WriteLine("Вы ввели число, не входящее в нужный диапозон");

