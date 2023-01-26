// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));

// Функция_1(принимает сообщение, и выводит результат)
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
// Функция_2(принимает число введенное пользователем, количество символов, и выводит третью цифру числа. Если 3 цифры нет, сообщает и выводит 0)
int MakeArray(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        Console.Write("Третьей цифры в введенных данных нет, т.е.: ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }
        result = (a / c) % 10;
    }
return result;
}