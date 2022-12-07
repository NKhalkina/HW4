/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;

    while(!isCorrect)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число или 0. Введите корректное число");
        }
    }
    return result;
}

int number = GetNumber("Введите число");
int summ = 0;
{
    
    while (number > 0)
    {
    summ = summ + number % 10;
    number = number / 10;
    }
}
Console.WriteLine(summ);





