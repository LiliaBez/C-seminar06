/* Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.*/

/*Вероятно, как то сюда нужно вписать двумерные массивы
и рекурсию... или хотя бы функции, но что-то не соображу..*/


Console.WriteLine("Введите через запятую значения b1, k1 и b2, k2 ");

double[] array = Array.ConvertAll(Console.ReadLine().Split(','), double.Parse);

double firstPoint = (array[2] - array[0]) / (array[1] - array[3]);
double secondPoint = array[1] * firstPoint + array[0];

Console.WriteLine($"Координаты точки пересечения прямых: ({firstPoint}, {secondPoint})");



