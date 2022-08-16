// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int calculationFunction (int x, int y)
{
    int result = x;
    for (int i = 1; i < y; i++)
    {
        result = result * x;
    }
    return result;
}

Console.WriteLine("Введите два числа, а я возвезу первое число в степень равную второму числу");
Console.Write("Первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int degree = calculationFunction(number1, number2);
Console.WriteLine($"Результат вычислений: {degree}");