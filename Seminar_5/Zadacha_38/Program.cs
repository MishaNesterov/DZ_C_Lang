// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным значениями элементов массива.
// [3 7 22 2 78] -> 76

int InPut(string input)
{
    Console.Write(input);
    return Convert.ToInt32(Console.ReadLine());
}

void Array(double []a)
{
    for(int i = 0; i < a.Length; i++ )
    {
        double m = Convert.ToDouble(new Random().Next(0, 10000)) / 100;
        a[i] = m;      
    } 
}

void WriteArray(double[] a)
{
    Console.Write("[");
    for (int i = 0; i < a.Length; i++)
    {
        if (i < (a.Length - 1)) Console.Write(a[i] + "  ");      
        else Console.Write(a[i] + "]");
            
    }
}

int n = InPut("Введите количество элементов в массиве: ");
int size = n;
double[] a = new double[size];
Array(a);
WriteArray(a);

double minnum = a[0];
for (int i = 1; i < a.Length; i++)
{
    if (a[i] < minnum) minnum = a[i];
}
 
double maxnum = a[0];
for (int i = 1; i < a.Length; i++)
{
    if (a[i] > maxnum) maxnum = a[i];
}

int result1 = Convert.ToInt32((maxnum - minnum) * 100);
double result = Convert.ToDouble(result1);
Console.Write(" -> " + result / 100); 
