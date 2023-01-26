//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkHoliday(dayNumber));

// Функция_1(принимает сообщение, и выводит результат)
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
// Функция_2(принимает число от 1 до 7 и выводит сообщение - выходной день или нет).
string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("Под цифрой " + a + " - Выходной");
        }
        else
        {
            Console.Write("Под цифрой " + a + " - Рабочий");
        }
    }
    else
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7, нельзя определить день недели");
    }
    return " день.";
}