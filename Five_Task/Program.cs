// Найдите произведение пар в массиве. 
Console.Clear();
// int arrSize = int.Parse(Console.ReadLine());
int[] array = new int[12];
int p = 0;
for(int i = 0; i < array.Length; i++) array[i] = new Random().Next(1, 10);
for(int i = 0; i < array.Length; i++) Console.Write($"{array[i] + " "}");
Console.WriteLine();
for(int i = 0; i < 6; i++)
{
    p = array[i] * array[array.Length - 1 - i];
    
    Console.Write($"{p + " "}");
}

// Console.Write(p);
// Console.WriteLine();

// int p = 0;
// for(int i = 0; i < array.Length; i++) 
// { 
//     // prod = array[i] * array.Length;  
//     // Console.Write($"{prod + " "}");
//     // for(int i = 0; i > array.Length; i++)
//     p = array[array.Length - 1];
    
// } Console.Write(p);
          