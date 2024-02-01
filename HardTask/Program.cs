//Со * **:
//-Создать программу работы с матрицами (двухмерными массивами) c возможностью выбора размера матрицы.
//- Элементы вводятся вручную (можно использовать рандомное заполнение).
//- Вывести матрицу на консоль с оформлением, чтобы выглядело как матрица.
//- Реализовать меню выбора действий:
// Найти количество положительных/отрицательных чисел в матрице.
// Сортировка элементов матрицы построчно (в двух направлениях).
// Инверсия элементов матрицы построчно.
// Все математические операции реализовать вручную, без использования статических методов класса Array.

//Оооочень долго делал. Уверен можно сделать более компактнее. Например, перебор каждого элемента массива в метод.

Random random = new Random();

Console.WriteLine("Введи количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи количество колонок: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[rows, columns];

DoRandom(random, rows, columns, arr); // Заполнить матрицу случайными числами
PrintMatrix(rows, columns, arr); // Напечатать матрицу
MenuActionsPrint(); // Напечатать меню действий


void ChooseAction()
{
    int action = Convert.ToInt32(Console.ReadLine());
    switch (action)
    {
        case 1:
            CountPositiveNegative(arr);
            break;
        case 2:
            SortMatrix();
            break;
        case 3:
            InverseMatrix();
            break;
    }
} // Выбрать действие на основе пользовательского ввода
void InverseMatrix()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns / 2; j++)
        {
            int temp = arr[i, j];
            arr[i, j] = arr[i, columns - j - 1];
            arr[i, columns - j - 1] = temp;
        }
    }

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
    UserAction(rows, columns, arr);

} // Инвертировать элементы матрицы построчно
void SortMatrix()
{

    Console.WriteLine("От большего к меньшему: ");
    Console.WriteLine("");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int m = 0; m < rows; m++)
            {
                for (int n = 0; n < columns; n++)
                {
                    if (arr[i, j] > arr[m, n])
                    {
                        int temp = arr[i, j];
                        arr[i, j] = arr[m, n];
                        arr[m, n] = temp;
                    }
                }
            }
        }
    }

    // Вывод отсортированного массива
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("");
    Console.WriteLine("От меньшего к большему: ");
    Console.WriteLine("");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int m = 0; m < rows; m++)
            {
                for (int n = 0; n < columns; n++)
                {
                    if (arr[i, j] < arr[m, n])
                    {
                        int temp = arr[i, j];
                        arr[i, j] = arr[m, n];
                        arr[m, n] = temp;
                    }
                }
            }
        }
    }

    // Вывод отсортированного массива
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }

    UserAction(rows, columns, arr);

} // Отсортировать матрицу
void CountPositiveNegative(int[,] arr)
{
    int countPositive = 0;
    int countNegative = 0;
    foreach (int item in arr)
    {
        if (item > 0)
        {
            countPositive++;
        }
        else if (item < 0)
        {
            countNegative++;

        }

    }
    Console.WriteLine($"Количесто положительных чисел: {countPositive}");
    Console.WriteLine($"Количесто отрицательных чисел: {countNegative}");
    UserAction(rows, columns, arr);



} // Подсчитать количество положительных и отрицательных чисел в матрице
void UserAction(int rows, int columns, int[,] arr)
{
    Console.WriteLine("Желаете продолжить? (y/n)");
    string? input = Console.ReadLine();
    if (input == "y")
        MenuActionsPrint();
} // Запросить у пользователя дальнейшие действия
void MenuActionsPrint()
{
    Console.Clear();
    PrintMatrix(rows, columns, arr);
    Console.WriteLine("Меню. Выбери действие: ");
    Console.WriteLine("1. Найти количество положительных/отрицательных чисел в матрице.");
    Console.WriteLine("2. Сортировка элементов матрицы построчно (в двух направлениях).");
    Console.WriteLine("3. Инверсия элементов матрицы построчно.");
    ChooseAction();
} // Напечатать меню действий
void DoRandom(Random random, int rows, int columns, int[,] arr)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = random.Next(-100, 100);
        }
    }
} // Заполнить матрицу случайными числами
void PrintMatrix(int rows, int columns, int[,] arr)
{
    Console.WriteLine("Дана матрица: \n");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("");
} // Напечатать матрицу