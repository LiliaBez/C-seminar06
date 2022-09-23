/*Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

Console.WriteLine("Введите числа через запятую:");

int[] numbers = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);

Console.WriteLine($"Количество чисел больше 0: {CountNumberPositiv(numbers)}");



int CountNumberPositiv(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
            count++;
    }
    return count;
}



