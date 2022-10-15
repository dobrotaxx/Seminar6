/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива 
с помощью поэлементного копирования.
*/

int[] CopyArray(int[] array)
{
    int[] CopyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        CopyArray[i] = array[i];
    }
    return CopyArray;
}

void printArray(int[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

int[] array = { 1, 2, 3, 4, 5, 6 };
int[] newArray = CopyArray(array);
printArray(array);
printArray(newArray);
