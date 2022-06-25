// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] InitArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] arrA)
{
    for (int i = 0; i < arrA.Length; i++)
    {
        System.Console.Write($"{arrA[i]} ");
    }
    System.Console.WriteLine();
}

int SearchEvenElements(int[] arrA)
{
    int sum = 0;
    for (int i = 0; i < arrA.Length; i += 2)
    {
        sum += arrA[i];
    }
    return sum;
}
int[] myArray = InitArray(5, 1, 10);
PrintArray(myArray);
int sum = SearchEvenElements(myArray);
System.Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях = {sum}");