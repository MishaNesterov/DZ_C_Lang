// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int InPut(string input)
{
    Console.Write(input);
    return Convert.ToInt32(Console.ReadLine());
}

void Array(int []a)
{
    for(int i = 0; i < a.Length; i++ )
    {
        a[i] = new Random().Next(100, 1000);      
    } 
}

void WriteArray(int[] a, int k = 0)
{
    Console.Write("[");
    for (int i = 0; i < a.Length; i++)
    {
        if (i < (a.Length - 1)) Console.Write(a[i] + ", ");       
        else Console.Write(a[i] + "]");       
        if (a[i] % 2 == 0) k++; 
    }
    Console.Write(" -> " + k);
}

int n = InPut("Введите количество элементов в массиве: ");
int size = n;
int[] a = new int[size];
Array(a);
WriteArray(a);
