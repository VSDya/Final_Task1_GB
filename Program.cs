// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите размер массива");
        int size;
        size = (int)inputValue();

        Console.WriteLine("Введите массив");
        string[] array = new string[size];
        int index;
        index = 0;
        while (index < size)
        {
            array[index] = Console.ReadLine();
            index = index + 1;
        }
        index = 0;
        Console.WriteLine("Полученный массив");
        Console.Write("[");
        while (index < size)
        {
            Console.Write(array[index] + " ");
            index = index + 1;
        }
        Console.Write("]");
        index = 0;
        string[] arrayResult = new string[size];
        int temp;
        temp = 0;
        for (index = 0; index <= size - 1; index++)
        {
            if (array[index].Length <= 3)
            {
                arrayResult[temp] = array[index];
                temp = temp + 1;
            }
        }
        Console.Write(" -> [");
        for (index = 0; index <= temp - 1; index++)
        {
            Console.Write(arrayResult[index] + " ");
        }
        Console.Write("]");
    }
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
