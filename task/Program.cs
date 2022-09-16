// Итоговая проверочная работа
Console.Clear();
Console.WriteLine($"\nИтоговая проверочная работа.");


// Объявление первичных данных
Console.WriteLine($"\nИз имеющегося массива сформировать новый только с теми элементами, длина которых не более 3-х символов.\n");
string[] matrix = new string[5] { "Final", "work", "1", "quarter", "res" };
string[] matrix_sort = new string[matrix.Length];
int max = 3;

void SecondArray(string[] matrix, string[] matrix_sort)
{
    int count = 0;
    for (int i = 0; i < matrix.Length; i++)
    {
        if (matrix[i].Length <= max)
        {
            matrix_sort[count] = matrix[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    Console.WriteLine($"Первичный массив:");
    Console.WriteLine($"[{String.Join(", ", matrix)}]\n");
    // Удаляем пустые элементы массива
    array = array.Where(x => !string.IsNullOrEmpty(x)).ToArray();
    // Вывод массива
    Console.WriteLine($"Новый массив:");
    Console.Write($"[{String.Join(", ", array)}]");
}

// Выполнение программы
SecondArray(matrix, matrix_sort);
PrintArray(matrix_sort);