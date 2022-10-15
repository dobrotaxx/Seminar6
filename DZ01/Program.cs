/*
Задача 41.
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

int getNumberFromUser(string userInformation)
{
    int result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0 && userLine != "0")
        {
            Console.WriteLine($"Ошибка ввода! Введите целое число: [{userLine}].");
        }
        else
        {
            break;
        }
    }
    return result;
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

int[] userNumbers(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива с индексом {i}: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

int checkUpUserNum(int[] array)
{
    int greaterThanZero = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            greaterThanZero++;
        }
    }
    return greaterThanZero;
}

int array = getNumberFromUser("Задайте длину массива: ");
int[] userArray = userNumbers(array);
int greaterThanZero = checkUpUserNum(userArray);
printArray(userArray);
Console.Write($"Число элементов в массиве, которые больше нуля [{greaterThanZero}]");