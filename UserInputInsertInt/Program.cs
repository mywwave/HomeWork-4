//Напишите программу, где пользователь вводит любое целое положительное число.
//А программа суммирует все числа от 1 до введенного пользователем числа.

//TODO: Сделать проверку введенного числа на целое положительное 


while (true)
{
    Console.WriteLine("Введите любое целое положительное число");
    try
    {
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        if (number < 0)
        {
            Console.WriteLine("Число отрицательное. Введите целое положительное число");
            continue;
        }

        for (int i = 1; i <= number; i++)
        {
            sum += i;
        }

        Console.WriteLine($"Сумма чисел от 1 до {number} = {sum}");
        break;
    }
    catch
    {
        Console.WriteLine("Неверно. Введите целое положительное число");
    }
}
