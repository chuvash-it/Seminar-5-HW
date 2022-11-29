//Урок 5. Функции и одномерные массивы
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

//int [] numbers = new int [8];
//array (numbers);
//Console.WriteLine();
//evennum (numbers);
//void array (int [] arr)
//{
//    for (int i = 0; i < arr.Length; i++)
//    {
//        arr[i] = new Random().Next(100, 999);
//        Console.Write($"{arr[i]} ");
//    }
//}
//void evennum (int [] nums)
//{
//    int result = 0;
//    foreach (int number in numbers)
//    {
//        if ((number % 2) < 1)
//        {
//            result++;
//        }
//    }
//    Console.WriteLine($"Количество четных числел в массиве: {result}");
//}

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

//int [] numbers = new int [8];
//array1 (numbers);
//Console.WriteLine();
//amount (numbers);
//void array1 (int [] arr)
//{
//    for (int i = 0; i < arr.Length; i++)
//    {
//        arr[i] = new Random().Next(-999, 999);
//        Console.Write($"{arr[i]} ");
//    }
//}
//void amount (int [] arr)
//{
//    int sum = 0;
//    for (int i = 0; i < arr.Length; i= i+2)
//    {
//        sum = sum + arr[i];
//    }
//    Console.WriteLine($"Сумма чисел на нечетных позициях: {sum}");
//}

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

// double [] numbers  = new double [8];
// array2(numbers);
// Console.WriteLine();
// delta(numbers);
// void array2 (double [] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(-99, 99);
//         Console.Write($"{arr[i]} ");
//     }

// }
// void delta (double [] arr)
// {
//     double max = arr[0];
//     for (int i = 1; i < arr.Length; i++)
//     {
//         if (max < arr[i])
//         {
//             max = arr[i];
//         }
//     }
//     double min = arr[0];
//      for (int i = 1; i < arr.Length; i++)
//     {
//         if (min > arr[i])
//         {
//             min = arr[i];
//         }
//     }   
//     double delta = max - min;
//     Console.WriteLine($"Разниwа между максимальным ({max})  и минимальным ({min}) состовляет: {delta}");
// }