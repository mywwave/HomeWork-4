//Создайте 2 массива из 5 чисел.
//Выведите массивы на консоль в двух отдельных строках.
//Посчитайте среднее арифметическое элементов каждого массива и сообщите,
//для какого из массивов это значение оказалось больше (либо сообщите, что
//их средние арифметические равны).

int[] numbers = new int[5];
int[] numbers2 = new int[5];
Random random = new Random();

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(1, 11); // Заполнение элементов массива рандомными числами от 1 до 10
    numbers2[i] = random.Next(1, 11);
}

Console.WriteLine("Первый массив: ");
foreach (int i in numbers)
{
    Console.Write($"| {i} ");
}

Console.WriteLine("\nВторой массив: ");
foreach (int i in numbers2)
{
    Console.Write($"| {i} ");
}


double average1 = numbers.Average();
double average2 = numbers2.Average();
Console.WriteLine($"\nСреднее арифметическое первого массива: {average1}");
Console.WriteLine($"Среднее арифметическое второго массива: {average2}");

if ( average1 < average2)
{
    Console.WriteLine("Второй массив больше первого"); 
}
else if (average1 > average2) 
{
    Console.WriteLine("Первый массив больше второго"); 
}
else 
{
    Console.WriteLine("Средние арифметические равны"); 
}
