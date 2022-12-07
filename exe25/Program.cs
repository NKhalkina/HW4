/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число
A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

/*Получение числа с консоли*/
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
            Console.WriteLine("Ввели не число.");
        }
    }
    return result;
}


int A = GetNumber("Введите A");
int B = GetNumber("Введите B");

double Summ = Math.Pow((A), B);

Console.WriteLine(Summ);