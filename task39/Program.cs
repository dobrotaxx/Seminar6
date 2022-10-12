/*
Задача 39: Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

int[] generateArray(int length, int start, int end)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

void printArray(int[] arrayToPrint, string name)
{
    Console.WriteLine($"--------------{name}--------------");
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {

        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
    Console.WriteLine();
}

int[] reverseArray(int[] inputArray)
{
    int[] reversedArray = new int[inputArray.Length];
    for (int i = 0; i < inputArray.Length; i++)
    {
        reversedArray[i] = inputArray[inputArray.Length - i - 1];
    }
    return reversedArray;
}
int[] currentArray = generateArray(9, 10, 99);
printArray(currentArray, "Прямой");
int[] reversedArray = reverseArray(currentArray);
printArray(reversedArray, "Обратный");