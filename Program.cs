//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double [] numbers  = new double [8];
array2(numbers);
Console.WriteLine();
delta(numbers);
void array2 (double [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-99, 99);
        Console.Write($"{arr[i]} ");
    }

}
void delta (double [] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];
        }
    }
    double min = arr[0];
     for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
        }
    }   
    double delta = max - min;
    Console.WriteLine($"Разниwа между максимальным ({max})  и минимальным ({min}) состовляет: {delta}");
}