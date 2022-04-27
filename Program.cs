//: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int [] CreateRandomArray(int size, int min,int max) 
{
    int[] array = new int[size];
    for(int i = 0; i < size;i++)
    {
        array[i] = new Random().Next(min, max+1); 
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}
void evenNumber(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    if(array[i] %2 == 0)
        count++;
    
    Console.WriteLine("-> " + count);
}

int [] myArray = CreateRandomArray(5,100,999+1);
ShowArray(myArray);
evenNumber(myArray);
*/
//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int [] CreateRandomArray(int size, int min,int max) 
{
    int[] array = new int[size];
    for(int i = 0; i < size;i++)
    {
        array[i] = new Random().Next(min, max+1); 
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}
void SumOddNumber(int[] array)
{
    int SumOdd = 0;
    for(int i = 0; i < array.Length; i=i+2)
    {
        SumOdd = SumOdd +array[i];
    }

    
    Console.WriteLine("-> " + SumOdd);
}

int [] myArray = CreateRandomArray(5,-100,100+1);
ShowArray(myArray);
SumOddNumber(myArray);
*/
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
int [] CreateRandomArray(int size, int min,int max) 
{
    int[] array = new int[size];
    for(int i = 0; i < size;i++)
    {
        array[i] = new Random().Next(min, max+1); 
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}
void numdiff(int[] array)
{
    int numdiff = 0;
    int max = array[0];
    int min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
    if(max < array[i])
        max = array[i];
    if(min > array[i])
        min = array[i];
    }
    numdiff = max - min;
    Console.WriteLine("-> " + numdiff);
}
int [] myArray = CreateRandomArray(5,-100,100+1);
ShowArray(myArray);
numdiff(myArray);
*/