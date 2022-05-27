// Задать массив из 123 элементов. Подсчиать количество четных / нечетных.
int[] array = [123];
for(int i = 0; i < array.Length; i++) 
array[i] = new Random().Next(0,150);
foreach(int r in array)
     {
     Console.Write($"{r + " "}");
     }
     if(array[i] > 10 && array[i] < 99)
     {
         Console.WriteLine(count);
         count++;
     }



// while(index < n)
// {
//     if(array[index] == find) 
//     {
//     Console.WriteLine(index);
//     }
//     index++;
//  }


// Console.Clear();
// int arrSize = int.Parse(Console.ReadLine());
// int[] array = new int[arrSize];
// for(int i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 15);
// for(int i = 0; i < array.Length; i++) 
// Console.Write($"{array[i] + " "}");
// Console.WriteLine();

// int prod = 0;
// for(int i = 0; i < array.Length; i++) 
// { 
//     // prod = array[i] * array.Length;  
//     // Console.Write($"{prod + " "}");
//     for(int i = 0; i > array.Length; i++)
//     Console.Write($"{array[array.Length] + " "}");
//     break;
// }
          