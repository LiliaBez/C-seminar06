/* Напишите программу, которая перевернёт 
одномерный массив (последний элемент будет на первом 
месте, а первый - на последнем и т.д.)*/

//Array.Reverse (numbers);

int[] numbers = { 1, 2, 3, 4, 5, 6};
PrintArray(numbers);

ReverseArray(numbers);
PrintArray(numbers);


/* int temp = numbers[i];
  numbers[i] = numbers[j];   - функция Swap
  numbers[j] = temp;*/

void Swap(ref int a, ref int b) // ref  - передаем значения по ссылке, а не копированием
{
    int c = a;
    a = b;
    b = c;
}

/*void PrintArray(int[] numbers)
{
    Console.WriteLine(string.Join(", ", numbers));
} - если функция в одну строку, то можно использовать знак =>  */

void PrintArray(int[] numbers) => Console.WriteLine(string.Join(", ", numbers));



void ReverseArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length / 2; i++)
    {       // мы хотим поменять местами i-й с j-м
            //numbers.Length -1 -i   =  ^(i+1)   ^ - отсчет элементов с конца  
        Swap(ref numbers[i], ref numbers[^(i + 1)]);
    }
}


