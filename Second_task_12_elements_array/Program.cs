// Задать массив из 12-ти элементов заполниенный от -9 до 9. найти сумму +/- элементов.

Console.Clear();   
// Console.WriteLine("Введите размер массива, предпочитетельнее, 12: ");
// int arrSize = int.Parse(Console.ReadLine()?? "");
// int[] array = new int [arrSize];
int[] array = new int [12];
for(int i = 0; i < array.Length; i++) array[i] = new Random().Next(-9, 9);
for(int i = 0; i < array.Length; i++) Console.Write($"{array[i] + " "}");
int sumMinus = 0;
int sumPlus = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] < 0)
    {
        sumMinus = sumMinus + array[i];
    }    
    if(array[i] > 0)
    {
        sumPlus = sumPlus + array[i];
    }
}    Console.WriteLine();
     Console.Write($"Сумма отрицательных элементов массива равна: {sumMinus}"); 
     Console.WriteLine();       
     Console.Write($"Сумма положительных элементов массива равна: {sumPlus}");


// Ниже преведён вариант решения через float, а также, завод массива через doubel. 
// Это всё сделано для общего развития))) 

// double[] array = new double [12];

// for(int i = 0; i < 12; i++)
// {
//     array[i] = new Random().NextDouble()*12;
// }
// // for(int i = 0; i < 12; i++) Console.WriteLine($"{array[i]}");
// foreach(double k in array)
//        Console.WriteLine($"{k + " "}");




// Console.Clear();
// float [] arr = {3,5f, 6,23, 5,23, -23,56, 2,78, -3,4, 90,1, -34,2, 6,89, -3,45, 23,45, 1,2};
// for(int i = 0; i < arr.Length; i++)
// {
//     Console.Write(arr[i] + " ");
// }
// Console.WriteLine();
// double sum1 = 0;
// double sum2 = 0;
// for(int i = 0; i < arr.Length; i++)
// {
//     if(arr[i] > 0)
//       {
//           sum1 = sum1 + arr[i];
//       }
//    if(arr[i] < 0)
//     {
//           sum2 = sum2 + arr[i];
//     }   
// }    
//     Console.WriteLine($"Сумма положительных элементов массива = {sum1}");
//     Console.WriteLine($"Сумма отрицательных элементов массива = {sum2}");


// String[,] table = new string[2,5];
// // String,Empty
// // table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
// // table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]
 
// table[1,2] = "слово"; 
// for(int rows = 0; rows < 2; rows++)
// {
//     for(int colemns = 0; columns < 5; columns++)
//     {
//        Console.WriteLine($"--{table[rowes, columns]}--");               
//     }
// }
