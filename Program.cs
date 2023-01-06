Main();

void Main()
{
    bool isWorking = true;
    while (isWorking)
    {
        Console.Write("Input command: ");
        switch (Console.ReadLine())
        {
            case "H1": H1(); break;
            case "H2": H2(); break;
            case "H3": H3(); break;
            case "exit": isWorking = false; break;
        }
        Console.WriteLine();
    }
}
void H1()//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
{
Console.Write("Введите высоту массива:");
int length = int.Parse(Console.ReadLine());
Console.Write("Введите длинну массива:");
int secondLength = int.Parse(Console.ReadLine());


Random random = new Random(DateTime.Now.Millisecond);

double[,] array = new double[length , secondLength];
    for (int i = 0; i < length; i++)
    {
        
        
        for (int j = 0; j < secondLength; j++)
        {
            array[i,j] = random.NextDouble() * 10;
            Console.Write($"{array[i,j]},  ");
        }    
        Console.WriteLine();
    }    
}
void H2() //Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
{

Console.WriteLine ("Введите позицию элемента по оси X: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите позицию элемента по оси Y: ");
int x = int.Parse(Console.ReadLine());
int length = ReadInt();
int secondLength = ReadInt2();
int [,]  array = GetArray(length, secondLength);
PrintArray(array);
NotInMassive();
Console.ReadLine();
int ReadInt() 
{
    Console.WriteLine ("Введите длину по оси x: ");
    return int.Parse(Console.ReadLine());
}
int ReadInt2()
{
    Console.WriteLine ("Введите длину по оси y: ");
    return int.Parse(Console.ReadLine());
}

int[,] GetArray(int length, int secondLength)
{
    int[,] array = new int[length, secondLength];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        for(int j = 0; j < secondLength; j++)
        {
            array[i,j] = random.Next (100);
            if (x == i && y == j)
                {
                    Console.Write($"Значение элемента: {array[i, j]} ");
                }
        }
    }
    Console.WriteLine();
    return array;
}

void PrintArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void NotInMassive ()
{
    if(x >= length && y >= secondLength)
    {
        Console.WriteLine ("Такого числа нет!");
    }
}
}
void H3()//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
{
int length = ReadInt();
int secondLength = ReadInt();
int [,]  array = GetArray(length, secondLength);
PrintArray(array);
Console.ReadLine();
int ReadInt() 
{
    return int.Parse(Console.ReadLine());
}

int[,] GetArray(int length, int secondLength)
{
    int[,] array = new int[length, secondLength];
    Random random = new Random();
    int count = 0;
    for (int j = 0; j < length; j++)
    {
        double sum = 0;
        
        for(int i = 0; i < secondLength; i++)
        {
            array[i,j] = random.Next (10);
            sum = (sum + array[i,j]);
            
        }
        sum = sum/secondLength;
        count++;
        Console.WriteLine($"Среднеарифметическое {count} столбца: {sum} ");
    }
    Console.WriteLine();
    return array;
}


void PrintArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
}