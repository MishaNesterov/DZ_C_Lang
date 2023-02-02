//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int firstnumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondnumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int thirdnumber = int.Parse(Console.ReadLine());

if(firstnumber > secondnumber)
{
    if(firstnumber > thirdnumber)
    {
        Console.WriteLine(firstnumber);
    }
    else 
    {
        Console.WriteLine(thirdnumber);
    }
}

else if (secondnumber > thirdnumber)
{
    Console.WriteLine(secondnumber);
}
else
{
    Console.WriteLine(thirdnumber);
}