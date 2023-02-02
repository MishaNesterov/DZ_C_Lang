Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number; 
if(number < 100)
{
    Console.WriteLine("Число меньше трёхзначного");
}
else 
{
    while (number1 >= 1000)
    {
        number1 = number1 / 10;
    }
    Console.WriteLine($"В числе {number} третья цифра ----> {number1 % 10}");
}