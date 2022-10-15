/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли 
существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
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

void checkUp(int numA, int numB, int numC)
{
    if (numA < numB + numC)
    {
        if (numB < numA + numC)
        {
            if (numC < numA + numB)
            {
                Console.WriteLine($"Треугольник со сторонами [{numA}], [{numB}] и [{numC}] может существовать");
            }
            else
            {
                Console.WriteLine($"Треугольник со сторонами [{numA}], [{numB}] и [{numC}] не может существовать");
            }
        }
        else
        {
            Console.WriteLine($"Треугольник со сторонами [{numA}], [{numB}] и [{numC}] не может существовать");
        }
    }
    else
    {
        Console.WriteLine($"Треугольник со сторонами [{numA}], [{numB}] и [{numC}] не может существовать");
    }
}

int userNumA = getNumberFromUser("Введите число A: ");
int userNumB = getNumberFromUser("Введите число B: ");
int userNumC = getNumberFromUser("Введите число C: ");
checkUp(userNumA, userNumB,userNumC);
