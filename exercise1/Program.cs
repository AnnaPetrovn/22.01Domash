/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/ 

int [] YouShouldCreateArr () 
{
    Console.WriteLine("Введите числа через пробел");
    string s = Console.ReadLine();
   
    int[] a = s.Split(' ').Select(int.Parse).ToArray();
    for(int i = 0; i < a.Length; i++)
    {
        Console.WriteLine(a[i]);
    }
    return a;
    }

void WhatIsGreaterThanZero (int[]array)
{
    int greaterThanZero = 0;
    for(int i = 0; i< array.Length; i++)
    {
        if(array[i]>0)
        {
            greaterThanZero = greaterThanZero + 1;
        }
    }
    Console.WriteLine( "Количество чисел больше нуля " + greaterThanZero);
}
int [] arr = YouShouldCreateArr();
WhatIsGreaterThanZero(arr);