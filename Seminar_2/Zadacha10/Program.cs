Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999)
{
    
    Console.WriteLine("Число не трёхзначное. Введите трёхзначное число!");
}
else
{
    number = (number / 10) % 10;
    Console.WriteLine(number);
}