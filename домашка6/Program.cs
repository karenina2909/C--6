// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
/*
int [] Array (int n) // метод создания  массива из введенных с клавиатуры чисел
{
int [] arr = new int [n];
for (int i =0; i<n; i++)
{
    Console.WriteLine($"Введите {i + 1}-ое число массива ");
    arr[i]= Convert.ToInt32(Console.ReadLine());
}
return arr;
}

Console.WriteLine("Ведите количество элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
int [] a = Array(n);
 
//метод поиска положительных чисел в массиве
int A (int [] a) 
{
int count = 0;
for (int i =0; i<a.Length; i++)
{
    if (a[i]>0)
    {
        count = count+1;
    }
}
return count;
}
Console.WriteLine($"количество положительных элементов массива {A(a)}");
*/
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("коэффициент к1 ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("коэффициент b1 ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("коэффициент к2 ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("коэффициент b2 ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x (double k1,double b1,double k2,double b2)
{
    double x =0;
    x= (b2-b1)/(k1-k2);
    return x;
}
double X= Math.Round(x(k1,b1,k2,b2), 2);
double y (double k1,double b1, double x)
{
    double y = 0;
    y= k1 *x + b1;
    return y;
}
Console.WriteLine($"точка пересечения {X}; {Math.Round(y(k1,b1,X),2)}");
