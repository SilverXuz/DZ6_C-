/* ЗАДАЧА №1233 Транспонирование - 1
транспонировать ецелочисленную квадратную матрицу размером N x N относительно главной диагонали.
N – количество строк и столбцов матрицы
Все числа во входных данных не превышают 100 по абсолютной величине
*/


// Первый вариант решения
// Console.Write("Введите размер квадратной матрицы: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[n, n];
// void Array(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(0,100);
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void TranceArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[j, i]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Array(matrix);
// Console.WriteLine();
// TranceArray(matrix);



// Второй вариант решения
Console.Write("Введите размер квадратной матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
void Array(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0,100);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void TranceArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            int x = matrix[i, j];
            matrix[i, j] = matr[j, i];
            matr[j, i] = x;
            
        }
    }
    for (int i = 0; i < matr.GetLength(0); i++)
    {
            for (int j = 0; j < matr.GetLength(1); j++)
        {
           Console.Write($"{matr[i, j]} ");
            
        }
        Console.WriteLine();
    }
}

Array(matrix);
Console.WriteLine();
TranceArray(matrix);
