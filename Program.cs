 /*Пользователь вводит с клавиатуры M чисел. Посчитайте, 
 сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4 */

Console.Write("Введите количество чисел для ввода ");
int n = Convert.ToInt32(Console.ReadLine()!);
int[] array = new int[n];

for(int i = 0; i < n; i++){
    Console.WriteLine($"Введите {i + 1} -e число: ");
    array[i] = Convert.ToInt32(Console.ReadLine()!);
}
int count = 0;
for(int i = 0; i < n; i++){
    if(array[i] > 0) count++;
}
Console.WriteLine($"Чисел больше 0 введенных пользователем равно: {count}");