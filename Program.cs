// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] array = GetArray(10, 0, 1000);
// Console.WriteLine($"[{String.Join(",", array)}]");

// int chetSum = 0;
// for (int i = 0; i < array.Length; i++){
//     if (array[i] %2 ==0){
//         chetSum = chetSum +1;
//     }
// }

// Console.WriteLine($"Количество четных чисел в массиве = {chetSum}");

//  // Общий метод для создания одномерного массива
// int[] GetArray(int size, int minValue, int maxValue){
// int[] result = new int[size];
// for(int i = 0; i < size; i++){
// result[i] = new Random().Next(minValue, maxValue + 1);
// }
// return result;
// }




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
//  стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = GetArray(8, 0, 20);
// Console.WriteLine($"[{String.Join(",", array)}]");

// int nechetSum = 0;
// for (int i = 0; i < array.Length; i= i+2){
//     nechetSum = nechetSum + array[i];
// }

// Console.WriteLine($"Количество четных чисел в массиве = {nechetSum}");

// // Общий метод для создания одномерного массива
// int[] GetArray(int size, int minValue, int maxValue){
// int[] result = new int[size];
// for(int i = 0; i < size; i++){
// result[i] = new Random().Next(minValue, maxValue + 1);
// }
// return result;
// }



// Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным
//  элементов массива.
// [3, 4, 1, 77, 65] => 77 - 1 = 76

int[] array = GetArray(8, 0, 100);
 Console.WriteLine($"[{String.Join(",", array)}]");

int max = array[0];
int min = array[0];

 for (int i = 1; i < array.Length; i++){
    if (array[i] > max ){
        max = array[i];
    }
   if (array[i] < min ){
        min = array[i];
    }
 }
int diff = max - min;
Console.WriteLine($"Максимальный элемент = {max}");
Console.WriteLine($"Минимальный элемент = {min}");
 Console.WriteLine($"Разница между максимальным и минимальным элементом = {diff}");

// Общий метод для создания одномерного массива
int[] GetArray(int size, int minValue, int maxValue){
int[] result = new int[size];
for(int i = 0; i < size; i++){
result[i] = new Random().Next(minValue, maxValue + 1);
}
return result;
}