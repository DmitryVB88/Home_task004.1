// Найдите произведение пар в массиве. 
Console.Clear();
int arrSize = int.Parse(Console.ReadLine());
int[] array = new int[arrSize];
for(int i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 15);
for(int i = 0; i < array.Length; i++) 
Console.Write($"{array[i] + " "}");
Console.WriteLine();

int prod = 0;
for(int i = 0; i < array.Length; i++) 
{ 
    // prod = array[i] * array.Length;  
    // Console.Write($"{prod + " "}");
    for(int i = 0; i > array.Length; i++)
    Console.Write($"{array[array.Length] + " "}");
    break;
}
          