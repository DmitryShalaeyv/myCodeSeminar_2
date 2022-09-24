
/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.*/

void Task_10()
{
    Console.Write("Input number -> ");
    string num_str = Console.ReadLine();
    int num = int.Parse(num_str);
    int result = ((num % 100) - (num % 10)) / 10;

    Console.WriteLine($"Second digits: {result}");
}

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.*/

void Task_13()
{
    Console.Write("Input number -> ");
    string num_str = Console.ReadLine();
    int len = num_str.Length;
    int num = int.Parse(num_str);
    int exp = (int)Math.Pow(10, len - 3);

    if (len < 3) {
        Console.WriteLine("Третьей цифры нет");
        return;
    }
    if (len == 3) {
        Console.WriteLine($"Третья цифра {num % 10}");
        return;
    }

    int d3 = ((num - (num % exp)) / exp) % 10;
    Console.WriteLine($"Третья цифра {d3}");
}

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.*/

void Task_15()
{
    Console.Write("Input number (1...7) -> ");
    string num_str = Console.ReadLine();
    int digit = int.Parse(num_str);

    if((digit < 1) || (digit > 7))
    {
        Console.WriteLine("Неверный формат ввода");
        return;
    }
    if ((digit == 6) || (digit == 7)) Console.WriteLine("Выходной день");
    else Console.WriteLine("Рабочий день");
}

Console.WriteLine("Введите номер задачи -> ");
string num_str = Console.ReadLine();
int num = int.Parse(num_str);

if(num == 10)
{
    Task_10();
    return;
} 
if(num == 13)
{
    Task_13();
    return;
} 
if(num == 15)
{
    Task_15();
    return;
} 
else Console.WriteLine("Неверный номер задачи");
