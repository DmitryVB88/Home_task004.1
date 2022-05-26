// Создать массив заполненный положительными трёхзначными числами. 
// Показать количество чётных и нечётных чисел.
Console.WriteLine("Введите размер массива: ");
int arrSize = int.Parse(Console.ReadLine()?? "");
int[] array = new int [arrSize];
for(int i = 0; i < array.Length; i++)
{
   array[i] = new Random().Next(100, 999);
   }  
for(int i = 0; i < array.Length; i++)   
Console.Write($"{array[i] + " "}");  
Console.WriteLine();
int check = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    // Console.WriteLine($"{check} элементов в массиве четные");
    check++;
} 
Console.WriteLine($"{check} элементa-(ов) в массиве четные.");
Console.WriteLine($"Нечетных элементов в массиве {arrSize - check}.");
