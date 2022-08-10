/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

// Первое решение
// Console.WriteLine("Сколько чисел вы хотите ввести?");
// int m = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// for (int i = 0; i < m; i++)
//     {
//         Console.WriteLine("Воводите числе, как отрицательные, так и положительные");
//         int x = Convert.ToInt32(Console.ReadLine());
//         if (x > 0)
//         count++;
//     }
// Console.WriteLine(count);

//Второе решение
Console.WriteLine("Сколько чисел вы хотите ввести?");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];
int count = 0;
for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Воводите числе, как отрицательные, так и положительные");
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0)
            count++;
    }
Console.WriteLine("[" + string.Join(", ", array) + "] -> " + count);
