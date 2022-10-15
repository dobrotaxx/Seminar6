/*
Задача 43.
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, 
y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double getNumberFromUser(string userInformation)
{
    double result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        double.TryParse(userLine, out result);
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

double[] findingPoint(double b1, double k1, double b2, double k2)
{
    double[] y = new double[2];
    double x = (b2 - b1) / (k1 - k2);
    y[0] = k1 * x + b1;
    y[1] = k2 * x + b2;
    return y;
}

void printArray(double[] incomingArray)
{
    Console.Write("(");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length -1)
        {
            Console.Write("; ");
        }
    }
    Console.WriteLine(")");
}

double b1 = getNumberFromUser ("Введите точку координат b1: ");
double k1 = getNumberFromUser ("Введите точку координат k1: ");
double b2 = getNumberFromUser ("Введите точку координат b2: ");
double k2 = getNumberFromUser ("Введите точку координат k2: ");

double[] result = findingPoint(b1, k1, b2, k2);
printArray(result);