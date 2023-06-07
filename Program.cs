// Задача 34: Задайте массив заполненный случайными положительными трёхзначными
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int [] array = new int [5];
// int num = 0;
// for (int  i = 0; i< array.Length; i++)
// {
//     array[i] = new Random().Next(100,1000);
//     Console.Write(array[i] + " ");
//     if ( array[i]%2 == 0 )
//     {
//       num = num +1; 
//     }
    
// }

// Console.WriteLine($"Количество четных чисел : {num}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите
//  сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int size = 5;
// int [] array = new int [size];
// int numSum = 0;
// FillArray(array);
// PrintArray(array);

// for (int  i = 0; i < array.Length; i++)
//   {
//     if (i%2 != 0)
//     {
//        numSum = numSum +array[i]; 
       
//     }
//   }


// void FillArray ( int[] array)
// {
//     for( int i  = 0; i < array.Length;i++)
//     {
//         array[i] = new Random().Next(1, 100);
//     }
// }
// void PrintArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//          Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


// int size = 10;
// int[] array = new int[size];
// FillArray(array);
// PrintArray(array);

// int max = array[0];
// int min = array[0];

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
//     else if (array[i] < min)
//     {
//         min = array[i];
//     }
// }

// void FillArray ( int[] array)
// {
//     for( int i  = 0; i < array.Length;i++)
//     {
//         array[i] = new Random().Next(1, 1000);
//     }
// }

// void PrintArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//          Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine($"Минимальное число: {min}");
// Console.WriteLine($"Максимальное число: {max}");
// Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");



